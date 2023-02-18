namespace WinDocking.Docking
{
    using Themes;

    /// <summary>
    /// Visual Studio 2015 Light theme.
    /// </summary>
    public class VBlueTheme : VThemeBase
    {
        public VBlueTheme()
            : base(Decompress(Resources.blue_theme))
        {
        }
    }
}
