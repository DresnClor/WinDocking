using WinDocking.Docking;

namespace WinDocking.Themes
{
    internal class DockPaneSplitterControlFactory : DockPanelExtender.IDockPaneSplitterControlFactory
    {
        public DockPane.SplitterControlBase CreateSplitterControl(DockPane pane)
        {
            return new SplitterControl(pane);
        }
    }
}
