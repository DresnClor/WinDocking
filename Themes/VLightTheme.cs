namespace WinDocking.Docking
{
    using Themes;

    /// <summary>
    /// Visual Studio 2015 Light theme.
    /// </summary>
    public class VLightTheme : VThemeBase
    {
        public VLightTheme()
            : base(Decompress(Resources.light_theme))
        {
        }
    }
}
