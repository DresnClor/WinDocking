using WinDocking.Docking;

namespace WinDocking.Themes
{
    internal class AutoHideWindowFactory : DockPanelExtender.IAutoHideWindowFactory
    {
        public DockPanel.AutoHideWindowControl CreateAutoHideWindow(DockPanel panel)
        {
            return new AutoHideWindowControl(panel);
        }
    }
}
