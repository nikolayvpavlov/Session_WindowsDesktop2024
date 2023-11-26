using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Hosting;

namespace CWinFormsIslands
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private DesktopWindowXamlSource xamlSource { get; set; }

        private void InitializeIsland()
        {
            DispatcherQueueController.CreateOnCurrentThread();
            var panelWndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(pXamlIsland.Handle);
            xamlSource = new DesktopWindowXamlSource();
            xamlSource.Initialize(panelWndId);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeIsland();
        }

        private void bLoadIsland_Click(object sender, EventArgs e)
        {
            Grid gridRoot = new Grid()
            {

            };
            var button = new Microsoft.UI.Xaml.Controls.Button()
            {
                HorizontalAlignment = Microsoft.UI.Xaml.HorizontalAlignment.Center,
                Content = "Click me!",
            };
            button.Click += async (s, e) =>
            {
                ContentDialog contentDialog = new ContentDialog()
                {
                    XamlRoot = gridRoot.XamlRoot,
                    Title = "Information",
                    Content = "Hello from WinUI 3!",
                    CloseButtonText = "OK"
                };
                await contentDialog.ShowAsync();
            };
            gridRoot.Children.Add(button);
            xamlSource.Content = gridRoot;
        }

        private void bLoadCustomPage_Click(object sender, EventArgs e)
        {
            MyWinUILibrary.MyFabulousPage page = new MyWinUILibrary.MyFabulousPage();
            xamlSource.Content = page;
        }
    }
}
