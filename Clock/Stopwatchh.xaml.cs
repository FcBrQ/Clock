using System.Diagnostics;

namespace Clock;

public partial class Stopwatchh : ContentPage
{
	public Stopwatchh()
	{
		InitializeComponent();
	}
    Stopwatch watch = new Stopwatch();
    TimeSpan swattchtime = new TimeSpan();
    IDispatcherTimer timer;
    

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
		timer = Application.Current.Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += Timertimer_Tick;
    }

    private void Timertimer_Tick(object sender, EventArgs e)
    {
        swattchtime = swattchtime.Add(new TimeSpan(0, 0, -1));
        SwatchPicker.Time = swattchtime;
        if (swattchtime.Seconds == 0 && swattchtime.Hours == 0 && swattchtime.Minutes ==0) 
        {
            DisplayAlert("Внимание!!!", "Время вышло", "Продолжить");
            timer.Stop();
        }
    }

    private void StartBT_Clicked(object sender, EventArgs e)
    {
        swattchtime = SwatchPicker.Time;
        timer.Start();
    }

    private void CancelBT_Clicked(object sender, EventArgs e)
    {
        timer.Stop();
    }
}