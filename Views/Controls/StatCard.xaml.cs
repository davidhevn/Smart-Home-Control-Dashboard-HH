namespace SmartHome.App.Views.Controls;

public partial class StatCard : ContentView
{
	public StatCard()
	{
        InitializeComponent();
	}
    public static readonly BindableProperty CardBgProperty =
        BindableProperty.Create(nameof(CardBg), typeof(Color), typeof(StatCard), Colors.White);

    public static readonly BindableProperty IconBgProperty =
        BindableProperty.Create(nameof(IconBg), typeof(Color), typeof(StatCard), Colors.Blue);

    public static readonly BindableProperty AccentProperty =
        BindableProperty.Create(nameof(Accent), typeof(Color), typeof(StatCard), Colors.Blue);

    public static readonly BindableProperty IconTextProperty =
        BindableProperty.Create(nameof(IconText), typeof(string), typeof(StatCard), "•");

    public static readonly BindableProperty ValueTextProperty =
        BindableProperty.Create(nameof(ValueText), typeof(string), typeof(StatCard), "");

    public static readonly BindableProperty LabelTextProperty =
        BindableProperty.Create(nameof(LabelText), typeof(string), typeof(StatCard), "");

    public Color CardBg { get => (Color)GetValue(CardBgProperty); set => SetValue(CardBgProperty, value); }
    public Color IconBg { get => (Color)GetValue(IconBgProperty); set => SetValue(IconBgProperty, value); }
    public Color Accent { get => (Color)GetValue(AccentProperty); set => SetValue(AccentProperty, value); }
    public string IconText { get => (string)GetValue(IconTextProperty); set => SetValue(IconTextProperty, value); }
    public string ValueText { get => (string)GetValue(ValueTextProperty); set => SetValue(ValueTextProperty, value); }
    public string LabelText { get => (string)GetValue(LabelTextProperty); set => SetValue(LabelTextProperty, value); }
}