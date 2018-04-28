using ComponentFactory.Krypton.Toolkit;

namespace KryptonToolkitUpdater.UI
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonForm" />
    public partial class UpdateDetailsForm : KryptonForm
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="UpdateDetailsForm"/> class.
        /// </summary>
        public UpdateDetailsForm()
        {
            InitializeComponent();
        }

        private void kbtnRemindMeLater_Click(object sender, System.EventArgs e)
        {
            RemindMeLaterForm remindMeLater = new RemindMeLaterForm();

            remindMeLater.Show();
        }
    }
}