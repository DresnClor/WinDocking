namespace WinDocking.Docking
{
    using Themes;

    /// <summary>
    /// Visual Studio 2015 Light theme.
    /// </summary>
    public class VDarkTheme : VThemeBase
    {
        public VDarkTheme()
            : base(Decompress(Resources.dark_theme))
        {
        }
    }
}
