namespace Clock;

public partial class Alarm : ContentPage
{
	
	public Alarm()
	{
		InitializeComponent();
	}
    TimeSpan time;
    IDispatcherTimer timer;
    

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        timer = Application.Current.Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += Timer_Tick;
        
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        DateTime nowDay = DateTime.Now;
        TimeSpan nowTime = new TimeSpan(nowDay.Hour, nowDay.Minute, 0);

        if (time.CompareTo(nowTime) == 0)
        {
            if ((MondayCB.IsChecked == true && nowDay.DayOfWeek == DayOfWeek.Monday) || (TuesdayCB.IsChecked == true && nowDay.DayOfWeek == DayOfWeek.Tuesday) || (WednesdayCB.IsChecked == true && nowDay.DayOfWeek == DayOfWeek.Tuesday) || (TuesdayCB.IsChecked == true && nowDay.DayOfWeek == DayOfWeek.Saturday) || (FridayCB.IsChecked == true && nowDay.DayOfWeek == DayOfWeek.Friday) || (SaturdayCB.IsChecked == true && nowDay.DayOfWeek == DayOfWeek.Saturday) || (SundayCB.IsChecked == true && nowDay.DayOfWeek == DayOfWeek.Sunday))
            {
                DisplayAlert("Внимание", "Просыпайтесь", "Еще 5 минут ....");
                timer.Stop();
            }
            
        } 
    }

    private void AlarmBT_Clicked(object sender, EventArgs e)
    {
        timer.Start();
        time = AlaramTime.Time;
        
    }

    private void CancelBT_Clicked(object sender, EventArgs e)
    {
        timer.Stop();

    }
}