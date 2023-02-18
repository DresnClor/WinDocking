using WinDocking.Docking;

namespace WinDocking.Themes
{
    internal class DockIndicatorFactory : DockPanelExtender.IDockIndicatorFactory
    {
        public DockPanel.DockDragHandler.DockIndicator CreateDockIndicator(DockPanel.DockDragHandler dockDragHandler)
        {
            return new DockPanel.DockDragHandler.DockIndicator(dockDragHandler) { Opacity = 0.7 };
        }
    }
}