using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BGSnippet
{
    public partial class ReferencePointSelector : UserControl
    {
        private bool isMousePointerOverControl;

        private GraphicsPath[] cornerPaths;

        private GraphicsPath cornerPathTopLeft, cornerPathTopRight,
            cornerPathBottomLeft, cornerPathBottomRight, highlightPath;

        private AnchorStyles referencePointLocationX = AnchorStyles.Left;
        private AnchorStyles referencePointLocationY = AnchorStyles.Top;

        public AnchorStyles ReferencePointLocationX
        {
            get { return referencePointLocationX; }
            set
            {
                referencePointLocationX = value;
                Refresh();
            }
        }

        public AnchorStyles ReferencePointLocationY
        {
            get { return referencePointLocationY; }
            set
            {
                referencePointLocationY = value;
                Refresh();
            }
        }

        public ReferencePointSelector()
        {
            InitializeComponent();
            CalculateCornerPaths();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawInactiveElements(e);
            DrawSelectedCorner(e);
            DrawHighlight(e);
        }

        #region Drawing

        private void DrawSelectedCorner(PaintEventArgs e)
        {
            var activeCornerPath =
                GetPathForSpecifiedAnchors(referencePointLocationX, referencePointLocationY);

            DrawShapeWithOutline(e, activeCornerPath, selectedCornerFill, selectedCornerOutline);
        }

        private void DrawHighlight(PaintEventArgs e)
        {
            if (isMousePointerOverControl)
            {
                DrawShapeWithOutline(e, highlightPath, highlightFill, highlightOutline);
            }
        }

        private void DrawShapeWithOutline(PaintEventArgs e, GraphicsPath shapePath, Brush shapeFill, Color outlineColor)
        {
            e.Graphics.FillPath(shapeFill, shapePath);

            using (Pen outlinePen = new Pen(outlineColor))
            {
                e.Graphics.DrawPath(outlinePen, shapePath);
            }
        }

        private void DrawInactiveElements(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(controlFill, e.ClipRectangle);

            using (Pen inactiveCornerFramePen = new Pen(inactiveCornerOutline))
            using (Pen controlFramePen = new Pen(controlOutline))
            {
                foreach (var cornerPath in cornerPaths)
                {
                    e.Graphics.FillPath(inactiveCornerFill, cornerPath);
                    e.Graphics.DrawPath(inactiveCornerFramePen, cornerPath);
                }
                e.Graphics.DrawRectangle(controlFramePen, 0, 0, Width - 1, Height - 1);
            }
        }

        #endregion Drawing

        #region CoordinatesTransformations

        private void CalculateCornerPaths()
        {
            var rightEdge = Width - 2;
            var bottomEdge = Height - 2;

            byte[] pointTypes = new byte[] { 0, 1, 129 };

            var topLeftCornerPoints = new Point[] {
                new Point(1, 1),
                new Point(1, cornerSize + 1),
                new Point(cornerSize + 1, 1) };

            var topRightCornerPoints = new Point[] {
                new Point(rightEdge - cornerSize, 1),
                new Point(rightEdge, cornerSize + 1),
                new Point(rightEdge, 1) };

            var bottomLeftCornerPoints = new Point[] {
                new Point(1, bottomEdge),
                new Point(1, bottomEdge - cornerSize),
                new Point(cornerSize + 1, bottomEdge) };

            var bottomRightCornerPoints = new Point[] {
                new Point(rightEdge - cornerSize, bottomEdge),
                new Point(rightEdge, bottomEdge),
                new Point(rightEdge, bottomEdge - cornerSize) };

            cornerPathTopLeft = new GraphicsPath(topLeftCornerPoints, pointTypes);
            cornerPathTopRight = new GraphicsPath(topRightCornerPoints, pointTypes);
            cornerPathBottomLeft = new GraphicsPath(bottomLeftCornerPoints, pointTypes);
            cornerPathBottomRight = new GraphicsPath(bottomRightCornerPoints, pointTypes);

            cornerPaths = new[] {
                cornerPathTopLeft,
                cornerPathTopRight,
                cornerPathBottomLeft,
                cornerPathBottomRight
            };
        }

        private GraphicsPath GetPathForSpecifiedAnchors(AnchorStyles LocationX, AnchorStyles LocationY)
        {
            return LocationX == AnchorStyles.Left

                ? LocationY == AnchorStyles.Top ? cornerPathTopLeft
                                                : cornerPathBottomLeft

                : LocationY == AnchorStyles.Top ? cornerPathTopRight
                                                : cornerPathBottomRight;
        }

        private AnchorStyles GetHorizontalAnchorStyle(int coordinateX)
        {
            return coordinateX < Width / 2 ? AnchorStyles.Left
                                           : AnchorStyles.Right;
        }

        private AnchorStyles GetVerticalAnchorStyle(int coordinateY)
        {
            return coordinateY < Height / 2 ? AnchorStyles.Top
                                            : AnchorStyles.Bottom;
        }

        #endregion CoordinatesTransformations

        #region Events

        private void ReferencePointSelector_MouseMove(object sender, MouseEventArgs e)
        {
            isMousePointerOverControl = true;

            var horizontal = GetHorizontalAnchorStyle(e.X);
            var vertical = GetVerticalAnchorStyle(e.Y);

            highlightPath = GetPathForSpecifiedAnchors(horizontal, vertical);
            Refresh();
        }

        private void ReferencePointSelector_MouseLeave(object sender, EventArgs e)
        {
            isMousePointerOverControl = false;
            Refresh();
        }

        private void ReferencePointSelector_Click(object sender, EventArgs e)
        {
            var mouseClick = e as MouseEventArgs;

            referencePointLocationX = GetHorizontalAnchorStyle(mouseClick.X);
            referencePointLocationY = GetVerticalAnchorStyle(mouseClick.Y);
            Refresh();
        }

        #endregion Events

        #region VisualConfig

        private readonly int cornerSize = 8;

        private readonly Brush controlFill = Brushes.White;
        private readonly Color controlOutline = Color.Gray;

        private readonly Brush highlightFill = Brushes.Green;
        private readonly Color highlightOutline = Color.LightGreen;

        private readonly Brush selectedCornerFill = Brushes.LightBlue;
        private readonly Color selectedCornerOutline = Color.SteelBlue;

        private readonly Brush inactiveCornerFill = Brushes.WhiteSmoke;
        private readonly Color inactiveCornerOutline = Color.LightGray;

        #endregion VisualConfig
    }
}
