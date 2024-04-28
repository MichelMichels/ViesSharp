namespace MichelMichels.ViesSharp.Demo.Services;

public interface IThemeService
{
    event Action? ModeChanged;

    bool IsDarkMode { get; set; }
    void ToggleMode();
}
