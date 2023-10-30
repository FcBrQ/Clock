namespace Clock
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            TimeLB.Text = DateTime.Now.ToString("HH:mm:ss");
            IDispatcherTimer clocktimer; 
            clocktimer = Application.Current.Dispatcher.CreateTimer();
            clocktimer.Interval = TimeSpan.FromSeconds(1);
            clocktimer.Tick += Clocktimer_Tick;
            clocktimer.Start();
        }

        private void Clocktimer_Tick(object sender, EventArgs e)
        {
            TimeLB.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}