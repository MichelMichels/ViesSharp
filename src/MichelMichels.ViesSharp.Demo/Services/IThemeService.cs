namespace MichelMichels.ViesSharp.Demo.Services;

public interface IThemeService
{
    public bool IsDarkMode { get; set; }

    void ToggleMode();
}
