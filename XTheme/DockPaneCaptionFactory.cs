using WinDocking.Docking;

namespace WinDocking.Themes
{
    internal class DockPaneCaptionFactory : DockPanelExtender.IDockPaneCaptionFactory
    {
        public DockPaneCaptionBase CreateDockPaneCaption(DockPane pane)
        {
            return new DockPaneCaption(pane);
        }
    }
}
