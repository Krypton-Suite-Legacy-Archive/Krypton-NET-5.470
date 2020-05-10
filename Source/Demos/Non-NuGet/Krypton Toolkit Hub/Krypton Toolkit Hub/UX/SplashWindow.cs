using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitHub.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace KryptonToolkitHub.UX
{
    public partial class SplashWindow : KryptonForm
    {
        #region Variables
        private SettingsManager _settingsManager = new SettingsManager();
        private IOOperations _io = new IOOperations();
        public FadeEffects _fadeEffects = new FadeEffects();
        private Version _applicationVersion = Assembly.GetExecutingAssembly().GetName().Version;
        private string _fileDatabasePath = Directory.GetParent(Application.ExecutablePath).ToString() + @"\\Files", _fileName = @"\\File List.kfdb";
        #endregion

        public SplashWindow()
        {
            InitializeComponent();
        }

        private void SplashWindow_Load(object sender, EventArgs e)
        {
            _fadeEffects.FadeInWindow(this);

            if (_settingsManager.GetBetaVersion())
            {
                _io.ReturnApplicationExecutablePath();
            }

            if (_settingsManager.GetBetaVersion())
            {
                klblTitle.Values.ExtraText = $"Beta (Build: { _applicationVersion.Build.ToString() })";
            }
            else
            {
                klblTitle.Values.ExtraText = string.Empty;

                klblTitle.Location = new Point(278, 166);
            }
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            pbProgress.Increment(1);

            //if (TaskbarManager.IsPlatformSupported)
            //{
            //    TaskbarManager.Instance.SetProgressValue(pbProgress.Value, pbProgress.Maximum);

            //    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
            //}

            if (pbProgress.Value == 25)
            {
                //if (_settingsManager.GetFirstLaunch())
                //{
                //    if (_io.DoesFileExist(_fileDatabasePath))
                //    {
                //        _io.CreateFileList(Application.ExecutablePath, _fileDatabasePath);
                //    }
                //    else
                //    {
                //        _io.CreateFile(_fileDatabasePath);

                //        _io.CreateFileList(Application.ExecutablePath, _fileDatabasePath);
                //    }
                //}
            }
            else if (pbProgress.Value == pbProgress.Maximum)
            {
                MainWindow mainWindow = new MainWindow();

                _fadeEffects.FadeOutWindow(this, mainWindow);

                tmrSplash.Enabled = false;
            }
        }

        private void SplashWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
    }
}