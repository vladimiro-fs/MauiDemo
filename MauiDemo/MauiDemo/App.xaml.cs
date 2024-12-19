namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MyPage());

            navPage.BarBackgroundColor = Colors.Yellow;
            navPage.BarTextColor = Colors.Blue;

            MainPage = new TabbedPageDemo();
        }
    }
}
