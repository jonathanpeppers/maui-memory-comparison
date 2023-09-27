namespace MemoryComparison;

public partial class MainPage : ContentPage
{
	static int count = 1;

	public MainPage()
	{
		InitializeComponent();
	}

	async void OnNavigateClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage
		{
			Title = $"Page #{++count}",
		});
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		// NOTE: This is just for testing purposes!
		// Don't leave GC.Collect() calls in your production app
		GC.Collect();
	}
}

