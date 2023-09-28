namespace MemoryComparison;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

#if NET8_0
		Title = ".NET 8 Memory";
#elif NET7_0
		Title = ".NET 7 Memory";
#endif
	}
}
