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
        private static object locker = new object();
        private static FileSystemWatcher FileWatcher;
        private string appNameAndVersion = $"BGSnippet {typeof(MainWindow).Assembly.GetName().Version}";

        public MainWindow()
        {
            InitializeComponent();
            ConfigManager.LoadSettings();
            SetFormFieldsFromConfig();
            RunFileWatcher();

            notifyIcon.BalloonTipTitle = appNameAndVersion;
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(500);

            this.Text = appNameAndVersion;
            this.WindowState = FormWindowState.Minimized;
        }

        private void SetFormFieldsFromConfig()
        {
            cbxAutostart.CheckState = Config.Autostart ? CheckState.Checked : CheckState.Unchecked;
            txtboxSourceFile.Text = Config.SourceFilePath;
            txtboxOutputFile.Text = Config.TargetFilePath;
            txtboxWidth.Text = Config.SnippetWitdth.ToString();
            txtboxHeight.Text = Config.SnippetHeight.ToString();
            txtboxLeft.Text = Config.SnippetLeft.ToString();
            txtboxTop.Text = Config.SnippetTop.ToString();
            txtboxDelay.Text = Config.Delay.ToString();
        }

        private void SetConfigFromFormFields()
        {
            Config.SourceFilePath = txtboxSourceFile.Text;
            Config.TargetFilePath = txtboxOutputFile.Text;
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
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show(
                    "Failed to load the file. Check the file path.",
                    "IOException occured",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

        private void RunFileWatcher()
        {
            if (FileWatcher != null)
                FileWatcher.Dispose();

            try
            {
                FileWatcher = new FileSystemWatcher()
                {
                    Path = Path.GetDirectoryName(Config.SourceFilePath),
                    Filter = Path.GetFileName(Config.SourceFilePath),
                    NotifyFilter = NotifyFilters.LastWrite
                };
                FileWatcher.Changed += new FileSystemEventHandler(OnChanged);
                FileWatcher.EnableRaisingEvents = true;
                OnChanged(FileWatcher, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "File watcher failed to start. Please verify input file path.",
                    "Exception occured",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
            RunFileWatcher();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SetConfigFromFormFields();
            ConfigManager.SaveSettings();
            RunFileWatcher();
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
                notifyIcon.Visible = true;
                ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void CbxAutostart_Click(object sender, EventArgs e)
        {
            ConfigManager.SetRunOnSystemStartup(((CheckBox)sender).Checked);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
