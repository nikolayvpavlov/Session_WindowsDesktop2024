namespace BWinFormsUsingWASDK
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Microsoft.Windows.System.Power.PowerManager.RemainingChargePercentChanged += PowerManager_RemainingChargePercentChanged;
            Microsoft.Windows.System.Power.PowerManager.PowerSourceKindChanged += PowerManager_PowerSourceKindChanged;
        }

        private void PowerManager_PowerSourceKindChanged(object? sender, object e)
        {
            Invoke(() =>
            {
                textBoxPowerSource.Text = Microsoft.Windows.System.Power.PowerManager.PowerSourceKind.ToString();
            });
        }

        private void PowerManager_RemainingChargePercentChanged(object? sender, object e)
        {
            Invoke(() =>
            {
                progressBarBattery.Value = Microsoft.Windows.System.Power.PowerManager.RemainingChargePercent;
            });
        }
    }
}
