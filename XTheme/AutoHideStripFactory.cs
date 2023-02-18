using WinDocking.Docking;

namespace WinDocking.Themes
{
    internal class AutoHideStripFactory : DockPanelExtender.IAutoHideStripFactory
    {
        public AutoHideStripBase CreateAutoHideStrip(DockPanel panel)
        {
            return new AutoHideStrip(panel);
        }
    }
}
