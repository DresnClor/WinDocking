using WinDocking.Docking;

namespace WinDocking.Themes
{
    internal class DockWindowFactory : DockPanelExtender.IDockWindowFactory
    {
        public DockWindow CreateDockWindow(DockPanel dockPanel, DockState dockState)
        {
            return new VDockWindow(dockPanel, dockState);
        }
    }
}
