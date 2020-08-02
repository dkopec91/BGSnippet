using System;
using System.Threading;
using System.IO;
using System.Windows.Forms;

//TODO: Sometimes event is raised multiple times on single file change
//FileSystemWatcher bug/feature - multiple file system actions during the 
//writing process by software that modifies file
//NotifyFilter did not eliminate the problem, so I could disable raising events,
//and eanable them after set number of ms. Then I proceed with loading the file.

namespace BGSnippet
{
    public partial class MainWindow : Form
    {
        public static object locker = new object();
        public string appNameAndVersion = $"BGSnippet {typeof(MainWindow).Assembly.GetName().Version}";

        public MainWindow()
        {
            InitializeComponent();
            ConfigManager.LoadSettings();
            SetFormFieldsFromConfig();

            //Start file watch
            FileSystemWatcher FileWatcher = new FileSystemWatcher()
            {
                Path = Config.SourceFilePath,
                Filter = Config.SourceFileName,
                NotifyFilter = NotifyFilters.LastWrite
            };
            FileWatcher.Changed += new FileSystemEventHandler(OnChanged);
            FileWatcher.EnableRaisingEvents = true;
            OnChanged(FileWatcher, null);
            
            notifyIcon.BalloonTipTitle = appNameAndVersion;
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(500);

            this.Text = appNameAndVersion;
            this.WindowState = FormWindowState.Minimized;
            Hide();
        }

        private void SetFormFieldsFromConfig()
        {
            txtboxSourceFile.Text = Config.SourceFilePath + "\\" + Config.SourceFileName;
            txtboxOutputFile.Text = Config.TargetFilePath + "\\" + Config.TargetFileName;
            txtboxWidth.Text = Config.SnippetWitdth.ToString();
            txtboxHeight.Text = Config.SnippetHeight.ToString();
            txtboxLeft.Text = Config.SnippetLeft.ToString();
            txtboxTop.Text = Config.SnippetTop.ToString();
            txtboxDelay.Text = Config.Delay.ToString();
        }

        private void SetConfigFromFormFields()
        {
            Config.SourceFilePath = ConfigManager.GetFilePathFromFullPath(txtboxSourceFile.Text);
            Config.SourceFileName = ConfigManager.GetFileNameFromFullPath(txtboxSourceFile.Text);
            Config.TargetFilePath = ConfigManager.GetFilePathFromFullPath(txtboxOutputFile.Text);
            Config.TargetFileName = ConfigManager.GetFileNameFromFullPath(txtboxOutputFile.Text);
            Config.SnippetWitdth = int.Parse(txtboxWidth.Text);
            Config.SnippetHeight = int.Parse(txtboxHeight.Text);
            Config.SnippetLeft = int.Parse(txtboxLeft.Text);
            Config.SnippetTop = int.Parse(txtboxTop.Text);
            Config.Delay = int.Parse(txtboxDelay.Text);
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            FileSystemWatcher FileWatcher = (FileSystemWatcher)source;
            FileWatcher.EnableRaisingEvents = false;
            Thread.Sleep(Config.Delay);

            try
            {
                lock (locker)
                {
                    new SnippetExtractor();
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show(
                    "Try Increasing the delay parameter.",
                    "IOException occured",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetType().ToString(),
                    "Exception occured",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                FileWatcher.EnableRaisingEvents = true;
            }

            //bitmap cleanup
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            ShowInTaskbar = true;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            SetConfigFromFormFields();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SetConfigFromFormFields();
            ConfigManager.SaveSettings();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "Project webpage:\n  https://github.com/dkopec91/BGSnippet",
                    appNameAndVersion,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2,
                    0, "https://github.com/dkopec91/BGSnippet");
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                ShowInTaskbar = false;
            }
        }
    }
}
