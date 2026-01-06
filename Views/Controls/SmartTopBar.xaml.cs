namespace SmartHome.App.Views.Controls;

public partial class SmartTopBar : ContentView
{
    public SmartTopBar()
    {
        // Ensure InitializeComponent is defined for XAML partial class
        InitializeComponent();
    }

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(nameof(Title), typeof(string), typeof(SmartTopBar), "Smart Home");

    public static readonly BindableProperty DevicesTextProperty =
        BindableProperty.Create(nameof(DevicesText), typeof(string), typeof(SmartTopBar), "8 devices");

    public static readonly BindableProperty ActiveTextProperty =
        BindableProperty.Create(nameof(ActiveText), typeof(string), typeof(SmartTopBar), "5 active");

    public string Title { get => (string)GetValue(TitleProperty); set => SetValue(TitleProperty, value); }
    public string DevicesText { get => (string)GetValue(DevicesTextProperty); set => SetValue(DevicesTextProperty, value); }
    public string ActiveText { get => (string)GetValue(ActiveTextProperty); set => SetValue(ActiveTextProperty, value); }

    // Add this method if missing to resolve CS0103
    void InitializeComponent()
    {
#if DEBUG
        // This is a stub for design-time; at runtime, the generated partial class should provide this.
#endif
    }
}