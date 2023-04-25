namespace transparentgradient;

public class MainPage : ContentPage
{
	public MainPage()
	{
        var contentGrid = new Grid
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            BackgroundColor = Colors.WhiteSmoke,
            WidthRequest = 500,
            HeightRequest = 500,
            RowDefinitions =
            {
                new RowDefinition { Height = GridLength.Star },
                new RowDefinition { Height = 100 }
            }
        };

        var boxView = new BoxView
        {
            HorizontalOptions = LayoutOptions.Fill,
            VerticalOptions = LayoutOptions.Fill,
            Color = Colors.Transparent,
            Background = new LinearGradientBrush
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(0, 1),
                GradientStops = new GradientStopCollection
                {
                    new(Colors.Transparent, 0.1f),
                    new(Colors.White, 1f)
                }
            }
        };

        contentGrid.Add(boxView, 0, 1);

        Content = new Grid
        {
            HorizontalOptions = LayoutOptions.Fill,
            VerticalOptions = LayoutOptions.Fill,

            Children =
            {
                contentGrid
            }
        };
	}
}
