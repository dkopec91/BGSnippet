namespace BGSnippet
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBoxControlButtons = new System.Windows.Forms.GroupBox();
            this.tableLayoutControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.cbxAutostart = new System.Windows.Forms.CheckBox();
            this.mainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxInputFile = new System.Windows.Forms.GroupBox();
            this.txtboxSourceFile = new System.Windows.Forms.TextBox();
            this.groupBoxOutputFile = new System.Windows.Forms.GroupBox();
            this.txtboxOutputFile = new System.Windows.Forms.TextBox();
            this.groupBoxSnippetParameters = new System.Windows.Forms.GroupBox();
            this.tableLayoutSnippetParameters = new System.Windows.Forms.TableLayoutPanel();
            this.txtboxDelay = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.txtboxHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtboxWidth = new System.Windows.Forms.TextBox();
            this.txtboxTop = new System.Windows.Forms.TextBox();
            this.lblSnippetY = new System.Windows.Forms.Label();
            this.lblSnippetX = new System.Windows.Forms.Label();
            this.txtboxLeft = new System.Windows.Forms.TextBox();
            this.lblReferencePoint = new System.Windows.Forms.Label();
            this.referencePointSelector = new BGSnippet.ReferencePointSelector();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.systemTrayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseOrResume_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxControlButtons.SuspendLayout();
            this.tableLayoutControlButtons.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.groupBoxInputFile.SuspendLayout();
            this.groupBoxOutputFile.SuspendLayout();
            this.groupBoxSnippetParameters.SuspendLayout();
            this.tableLayoutSnippetParameters.SuspendLayout();
            this.systemTrayMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxControlButtons
            // 
            this.groupBoxControlButtons.Controls.Add(this.tableLayoutControlButtons);
            this.groupBoxControlButtons.Location = new System.Drawing.Point(8, 109);
            this.groupBoxControlButtons.Name = "groupBoxControlButtons";
            this.groupBoxControlButtons.Size = new System.Drawing.Size(100, 182);
            this.groupBoxControlButtons.TabIndex = 12;
            this.groupBoxControlButtons.TabStop = false;
            this.groupBoxControlButtons.Text = "Control";
            // 
            // tableLayoutControlButtons
            // 
            this.tableLayoutControlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutControlButtons.ColumnCount = 1;
            this.tableLayoutControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutControlButtons.Controls.Add(this.btnSave, 0, 1);
            this.tableLayoutControlButtons.Controls.Add(this.btnApply, 0, 0);
            this.tableLayoutControlButtons.Controls.Add(this.btnAbout, 0, 2);
            this.tableLayoutControlButtons.Controls.Add(this.cbxAutostart, 0, 3);
            this.tableLayoutControlButtons.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutControlButtons.Name = "tableLayoutControlButtons";
            this.tableLayoutControlButtons.RowCount = 4;
            this.tableLayoutControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutControlButtons.Size = new System.Drawing.Size(90, 157);
            this.tableLayoutControlButtons.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(3, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(3, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(84, 33);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(3, 81);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(84, 33);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // cbxAutostart
            // 
            this.cbxAutostart.AccessibleDescription = "";
            this.cbxAutostart.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxAutostart.AutoSize = true;
            this.cbxAutostart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxAutostart.Location = new System.Drawing.Point(3, 120);
            this.cbxAutostart.Name = "cbxAutostart";
            this.cbxAutostart.Size = new System.Drawing.Size(84, 34);
            this.cbxAutostart.TabIndex = 10;
            this.cbxAutostart.Text = "Autostart";
            this.cbxAutostart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxAutostart.UseVisualStyleBackColor = true;
            this.cbxAutostart.Click += new System.EventHandler(this.CbxAutostart_Click);
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainLayoutPanel.Controls.Add(this.groupBoxInputFile);
            this.mainLayoutPanel.Controls.Add(this.groupBoxOutputFile);
            this.mainLayoutPanel.Controls.Add(this.groupBoxControlButtons);
            this.mainLayoutPanel.Controls.Add(this.groupBoxSnippetParameters);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.mainLayoutPanel.Size = new System.Drawing.Size(284, 296);
            this.mainLayoutPanel.TabIndex = 6;
            // 
            // groupBoxInputFile
            // 
            this.groupBoxInputFile.Controls.Add(this.txtboxSourceFile);
            this.groupBoxInputFile.Location = new System.Drawing.Point(8, 3);
            this.groupBoxInputFile.Name = "groupBoxInputFile";
            this.groupBoxInputFile.Size = new System.Drawing.Size(269, 47);
            this.groupBoxInputFile.TabIndex = 10;
            this.groupBoxInputFile.TabStop = false;
            this.groupBoxInputFile.Text = "Input file";
            // 
            // txtboxSourceFile
            // 
            this.txtboxSourceFile.Location = new System.Drawing.Point(6, 19);
            this.txtboxSourceFile.Name = "txtboxSourceFile";
            this.txtboxSourceFile.Size = new System.Drawing.Size(257, 20);
            this.txtboxSourceFile.TabIndex = 0;
            // 
            // groupBoxOutputFile
            // 
            this.groupBoxOutputFile.Controls.Add(this.txtboxOutputFile);
            this.groupBoxOutputFile.Location = new System.Drawing.Point(8, 56);
            this.groupBoxOutputFile.Name = "groupBoxOutputFile";
            this.groupBoxOutputFile.Size = new System.Drawing.Size(269, 47);
            this.groupBoxOutputFile.TabIndex = 11;
            this.groupBoxOutputFile.TabStop = false;
            this.groupBoxOutputFile.Text = "Output file";
            // 
            // txtboxOutputFile
            // 
            this.txtboxOutputFile.Location = new System.Drawing.Point(6, 19);
            this.txtboxOutputFile.Name = "txtboxOutputFile";
            this.txtboxOutputFile.Size = new System.Drawing.Size(257, 20);
            this.txtboxOutputFile.TabIndex = 1;
            // 
            // groupBoxSnippetParameters
            // 
            this.groupBoxSnippetParameters.Controls.Add(this.tableLayoutSnippetParameters);
            this.groupBoxSnippetParameters.Location = new System.Drawing.Point(114, 109);
            this.groupBoxSnippetParameters.Name = "groupBoxSnippetParameters";
            this.groupBoxSnippetParameters.Size = new System.Drawing.Size(163, 182);
            this.groupBoxSnippetParameters.TabIndex = 13;
            this.groupBoxSnippetParameters.TabStop = false;
            this.groupBoxSnippetParameters.Text = "Snippet parameters";
            // 
            // tableLayoutSnippetParameters
            // 
            this.tableLayoutSnippetParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutSnippetParameters.ColumnCount = 2;
            this.tableLayoutSnippetParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutSnippetParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutSnippetParameters.Controls.Add(this.txtboxDelay, 1, 5);
            this.tableLayoutSnippetParameters.Controls.Add(this.lblDelay, 0, 5);
            this.tableLayoutSnippetParameters.Controls.Add(this.txtboxHeight, 1, 4);
            this.tableLayoutSnippetParameters.Controls.Add(this.lblHeight, 0, 4);
            this.tableLayoutSnippetParameters.Controls.Add(this.lblWidth, 0, 3);
            this.tableLayoutSnippetParameters.Controls.Add(this.txtboxWidth, 1, 3);
            this.tableLayoutSnippetParameters.Controls.Add(this.txtboxTop, 1, 2);
            this.tableLayoutSnippetParameters.Controls.Add(this.lblSnippetY, 0, 2);
            this.tableLayoutSnippetParameters.Controls.Add(this.lblSnippetX, 0, 1);
            this.tableLayoutSnippetParameters.Controls.Add(this.txtboxLeft, 1, 1);
            this.tableLayoutSnippetParameters.Controls.Add(this.lblReferencePoint, 0, 0);
            this.tableLayoutSnippetParameters.Controls.Add(this.referencePointSelector, 1, 0);
            this.tableLayoutSnippetParameters.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutSnippetParameters.Name = "tableLayoutSnippetParameters";
            this.tableLayoutSnippetParameters.RowCount = 7;
            this.tableLayoutSnippetParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutSnippetParameters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSnippetParameters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSnippetParameters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSnippetParameters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSnippetParameters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSnippetParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutSnippetParameters.Size = new System.Drawing.Size(150, 158);
            this.tableLayoutSnippetParameters.TabIndex = 5;
            // 
            // txtboxDelay
            // 
            this.txtboxDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxDelay.Location = new System.Drawing.Point(97, 133);
            this.txtboxDelay.Name = "txtboxDelay";
            this.txtboxDelay.Size = new System.Drawing.Size(50, 20);
            this.txtboxDelay.TabIndex = 6;
            this.txtboxDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDelay
            // 
            this.lblDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(3, 130);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(88, 26);
            this.lblDelay.TabIndex = 9;
            this.lblDelay.Text = "Delay [ms]";
            this.lblDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxHeight
            // 
            this.txtboxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxHeight.Location = new System.Drawing.Point(97, 107);
            this.txtboxHeight.Name = "txtboxHeight";
            this.txtboxHeight.Size = new System.Drawing.Size(50, 20);
            this.txtboxHeight.TabIndex = 5;
            this.txtboxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(3, 104);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(88, 26);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(3, 78);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(88, 26);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Width";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxWidth
            // 
            this.txtboxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxWidth.Location = new System.Drawing.Point(97, 81);
            this.txtboxWidth.Name = "txtboxWidth";
            this.txtboxWidth.Size = new System.Drawing.Size(50, 20);
            this.txtboxWidth.TabIndex = 4;
            this.txtboxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxTop
            // 
            this.txtboxTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxTop.Location = new System.Drawing.Point(97, 55);
            this.txtboxTop.Name = "txtboxTop";
            this.txtboxTop.Size = new System.Drawing.Size(50, 20);
            this.txtboxTop.TabIndex = 3;
            this.txtboxTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSnippetY
            // 
            this.lblSnippetY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSnippetY.AutoSize = true;
            this.lblSnippetY.Location = new System.Drawing.Point(3, 52);
            this.lblSnippetY.Name = "lblSnippetY";
            this.lblSnippetY.Size = new System.Drawing.Size(88, 26);
            this.lblSnippetY.TabIndex = 6;
            this.lblSnippetY.Text = "Snippet Y";
            this.lblSnippetY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSnippetX
            // 
            this.lblSnippetX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSnippetX.AutoSize = true;
            this.lblSnippetX.Location = new System.Drawing.Point(3, 26);
            this.lblSnippetX.Name = "lblSnippetX";
            this.lblSnippetX.Size = new System.Drawing.Size(88, 26);
            this.lblSnippetX.TabIndex = 5;
            this.lblSnippetX.Text = "Snippet X";
            this.lblSnippetX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxLeft
            // 
            this.txtboxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxLeft.Location = new System.Drawing.Point(97, 29);
            this.txtboxLeft.Name = "txtboxLeft";
            this.txtboxLeft.Size = new System.Drawing.Size(50, 20);
            this.txtboxLeft.TabIndex = 2;
            this.txtboxLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReferencePoint
            // 
            this.lblReferencePoint.AutoSize = true;
            this.lblReferencePoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReferencePoint.Location = new System.Drawing.Point(3, 0);
            this.lblReferencePoint.Name = "lblReferencePoint";
            this.lblReferencePoint.Size = new System.Drawing.Size(88, 26);
            this.lblReferencePoint.TabIndex = 10;
            this.lblReferencePoint.Text = "Reference point";
            this.lblReferencePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // referencePointSelector
            // 
            this.referencePointSelector.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.referencePointSelector.Location = new System.Drawing.Point(97, 3);
            this.referencePointSelector.MaximumSize = new System.Drawing.Size(50, 20);
            this.referencePointSelector.MinimumSize = new System.Drawing.Size(50, 20);
            this.referencePointSelector.Name = "referencePointSelector";
            this.referencePointSelector.ReferencePointLocationX = System.Windows.Forms.AnchorStyles.Left;
            this.referencePointSelector.ReferencePointLocationY = System.Windows.Forms.AnchorStyles.Top;
            this.referencePointSelector.Size = new System.Drawing.Size(50, 20);
            this.referencePointSelector.TabIndex = 11;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Runing in background";
            this.notifyIcon.BalloonTipTitle = "BGSnippet";
            this.notifyIcon.ContextMenuStrip = this.systemTrayMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BGSnippet";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // systemTrayMenuStrip
            // 
            this.systemTrayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseOrResume_MenuItem,
            this.exit_MenuItem});
            this.systemTrayMenuStrip.Name = "systemTrayMenuStrip";
            this.systemTrayMenuStrip.ShowImageMargin = false;
            this.systemTrayMenuStrip.Size = new System.Drawing.Size(128, 48);
            // 
            // pauseOrResume_MenuItem
            // 
            this.pauseOrResume_MenuItem.Name = "pauseOrResume_MenuItem";
            this.pauseOrResume_MenuItem.Size = new System.Drawing.Size(127, 22);
            this.pauseOrResume_MenuItem.Text = "Pause/Resume";
            this.pauseOrResume_MenuItem.Click += new System.EventHandler(this.pauseOrResume_MenuItem_Click);
            // 
            // exit_MenuItem
            // 
            this.exit_MenuItem.Name = "exit_MenuItem";
            this.exit_MenuItem.Size = new System.Drawing.Size(127, 22);
            this.exit_MenuItem.Text = "Exit";
            this.exit_MenuItem.Click += new System.EventHandler(this.exit_MenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.mainLayoutPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 335);
            this.MinimumSize = new System.Drawing.Size(300, 335);
            this.Name = "MainWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BGSnippet";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.groupBoxControlButtons.ResumeLayout(false);
            this.tableLayoutControlButtons.ResumeLayout(false);
            this.tableLayoutControlButtons.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            this.groupBoxInputFile.ResumeLayout(false);
            this.groupBoxInputFile.PerformLayout();
            this.groupBoxOutputFile.ResumeLayout(false);
            this.groupBoxOutputFile.PerformLayout();
            this.groupBoxSnippetParameters.ResumeLayout(false);
            this.tableLayoutSnippetParameters.ResumeLayout(false);
            this.tableLayoutSnippetParameters.PerformLayout();
            this.systemTrayMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxControlButtons;
        private System.Windows.Forms.FlowLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.GroupBox groupBoxInputFile;
        private System.Windows.Forms.GroupBox groupBoxOutputFile;
        private System.Windows.Forms.GroupBox groupBoxSnippetParameters;
        private System.Windows.Forms.TextBox txtboxSourceFile;
        private System.Windows.Forms.TextBox txtboxOutputFile;
        private System.Windows.Forms.TextBox txtboxDelay;
        private System.Windows.Forms.TextBox txtboxHeight;
        private System.Windows.Forms.TextBox txtboxWidth;
        private System.Windows.Forms.TextBox txtboxTop;
        private System.Windows.Forms.TextBox txtboxLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutControlButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutSnippetParameters;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lblSnippetX;
        private System.Windows.Forms.Label lblSnippetY;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.CheckBox cbxAutostart;
        private System.Windows.Forms.ContextMenuStrip systemTrayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pauseOrResume_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_MenuItem;
        private System.Windows.Forms.Label lblReferencePoint;
        private ReferencePointSelector referencePointSelector;
    }
}

