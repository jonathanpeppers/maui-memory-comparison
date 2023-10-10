namespace MemoryComparison;

public partial class MainPage : ContentPage
{
	static int count = 0;

	public MainPage()
	{
		InitializeComponent();

		version.Text = $".NET {Environment.Version}";
	}

	async void OnNavigateClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage
		{
			Title = $"Page #{count++}",
		});
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		// NOTE: This is just for testing purposes!
		// Don't leave GC.Collect() calls in your production app
		GC.Collect();

		// forceFullCollection so we maybe run multiple GCs?
		var total = GC.GetTotalMemory(forceFullCollection: true);
		text.Text = $"Total Memory:\n{total}";
	}
}

