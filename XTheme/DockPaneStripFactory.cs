using WinDocking.Docking;

namespace WinDocking.Themes
{
    public class DockPaneStripFactory : DockPanelExtender.IDockPaneStripFactory
    {
        public DockPaneStripBase CreateDockPaneStrip(DockPane pane)
        {
            return new DockPaneStrip(pane);
        }
    }
}
