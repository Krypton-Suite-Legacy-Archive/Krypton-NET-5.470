using ComponentFactory.Krypton.Toolkit;
using System;

namespace KryptonToolkitUpdater.UI
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonForm" />
    public partial class UpdatePackageDetails : KryptonForm
    {
        #region Variables
        string _updatePackageFilePath;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets UpdatePackageFilePath.
        /// </summary>
        /// <value>
        /// _updatePackageFilePath.
        /// </value>
        private string UpdatePackageFilePath
        {
            get
            {
                return _updatePackageFilePath;
            }


            set
            {
                _updatePackageFilePath = value;
            }
        }
        #endregion

        /// <summary>
        /// Initialises a new instance of the <see cref="UpdatePackageDetails"/> class.
        /// </summary>
        public UpdatePackageDetails(string updatePackageFilePath)
        {
            InitializeComponent();

            UpdatePackageFilePath = updatePackageFilePath;
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void UpdatePackageDetails_Load(object sender, EventArgs e)
        {
            LoadUpdatePackageFileInformation(UpdatePackageFilePath);
        }

        private void LoadUpdatePackageFileInformation(string updatePackageFilePath)
        {
            try
            {

            }
            catch (Exception exc)
            {

                throw;
            }
        }
    }
}