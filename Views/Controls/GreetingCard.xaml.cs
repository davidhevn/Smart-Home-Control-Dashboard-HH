namespace SmartHome.App.Views.Controls;

public partial class GreetingCard : ContentView
{
	public GreetingCard()
	{
		InitializeComponent();
	}
    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(GreetingCard), "Good Evening!");

    public static readonly BindableProperty SubtitleProperty =
        BindableProperty.Create(nameof(Subtitle), typeof(string), typeof(GreetingCard), "Your home is comfortable and secure");

    public static readonly BindableProperty TempValueProperty =
        BindableProperty.Create(nameof(TempValue), typeof(string), typeof(GreetingCard), "24°C");

    public static readonly BindableProperty TempStatusProperty =
        BindableProperty.Create(nameof(TempStatus), typeof(string), typeof(GreetingCard), "Perfect");

    public static readonly BindableProperty TagLeftProperty =
        BindableProperty.Create(nameof(TagLeft), typeof(string), typeof(GreetingCard), "Secure");

    public static readonly BindableProperty TagRightProperty =
        BindableProperty.Create(nameof(TagRight), typeof(string), typeof(GreetingCard), "89% Efficient");

    public string Title { get => (string)GetValue(TitleProperty); set => SetValue(TitleProperty, value); }
    public string Subtitle { get => (string)GetValue(SubtitleProperty); set => SetValue(SubtitleProperty, value); }
    public string TempValue { get => (string)GetValue(TempValueProperty); set => SetValue(TempValueProperty, value); }
    public string TempStatus { get => (string)GetValue(TempStatusProperty); set => SetValue(TempStatusProperty, value); }
    public string TagLeft { get => (string)GetValue(TagLeftProperty); set => SetValue(TagLeftProperty, value); }
    public string TagRight { get => (string)GetValue(TagRightProperty); set => SetValue(TagRightProperty, value); }
}