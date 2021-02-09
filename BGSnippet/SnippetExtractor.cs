using System.IO;
using System.Drawing;
using System;

namespace BGSnippet
{
    class SnippetExtractor
    {
        public SnippetExtractor()
        {
            Bitmap SourceBitmap = LoadFile();
            Bitmap SnippetBitmap = ExtractSnippet(ref SourceBitmap);
            SaveSnippet(ref SnippetBitmap);
        }

        private Bitmap LoadFile()
        {
            Bitmap SourceBitmap = new Bitmap(Config.SnippetWitdth, Config.SnippetHeight);

            using (Stream BitmapStream = System.IO.File.Open(Config.SourceFilePath, FileMode.Open))
            {
                Image SourceImage = Image.FromStream(BitmapStream);
                SourceBitmap = new Bitmap(SourceImage);
            }
            return SourceBitmap;
        }

        private Bitmap ExtractSnippet(ref Bitmap SourceBitmap)
        {
            var left = Config.ReferencePointLocationX == System.Windows.Forms.AnchorStyles.Left
                ? Config.SnippetLeft
                : SourceBitmap.Width - Math.Abs(Config.SnippetLeft);

            var top = Config.ReferencePointLocationY == System.Windows.Forms.AnchorStyles.Top
                ? Config.SnippetTop
                : SourceBitmap.Height - Math.Abs(Config.SnippetTop);

            return new Bitmap(SourceBitmap.Clone(
                new Rectangle(left, top, Config.SnippetWitdth, Config.SnippetHeight), 
                SourceBitmap.PixelFormat));
        }

        private void SaveSnippet(ref Bitmap pobjSnippet)
        {
            try
            {
                pobjSnippet.Save(Config.TargetFilePath);
            }
            catch (Exception) { };
        }

    }
}
