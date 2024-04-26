namespace MichelMichels.ViesSharp.Demo.Services;

public class ThemeService : IThemeService
{
    public bool IsDarkMode { get; set; } = true;

    public void ToggleMode()
    {
        IsDarkMode = !IsDarkMode;
    }
}
