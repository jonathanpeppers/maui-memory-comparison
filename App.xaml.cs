namespace MemoryComparison;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

#if WINDOWS || MACCATALYST
	protected override Window CreateWindow(IActivationState activationState)
	{
		var window = base.CreateWindow(activationState);
		window.MaximumWidth = 300;
		window.MaximumHeight = 550;
		return window;
	}
#endif
}
