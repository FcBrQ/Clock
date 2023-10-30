using System.Diagnostics;

namespace Clock;

public partial class Timer : ContentPage
{

	public Timer()
	{
		InitializeComponent();
        
    }

    IDispatcherTimer sptimer;
    Stopwatch watch = new Stopwatch();

    private void Sptimer_Tick(object sender, EventArgs e)
    {
        TimerLB.Text = watch.Elapsed.ToString("mm\\:ss");
    }

    private void StartButton_Clicked(object sender, EventArgs e)
    {
        sptimer.Start();
        watch.Start();
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        
        TimerLB.Text = ("00:00");
        sptimer = Application.Current.Dispatcher.CreateTimer();
        sptimer.Interval = TimeSpan.FromSeconds(1);
        sptimer.Tick += Sptimer_Tick;
    }

    private void StopButton_Clicked(object sender, EventArgs e)
    {
        sptimer.Stop();
        watch.Stop();
    }

    private void ClearButton_Clicked(object sender, EventArgs e)
    {
        watch.Reset();
        TimerLB.Text = ("00:00");
    }
}