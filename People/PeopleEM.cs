namespace People;

public class PeopleEM : ContentView
{
	public PeopleEM()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}

    public string Name { get; internal set; }
}