using WinDocking.Docking;

namespace WinDocking.Themes
{
    internal class WindowSplitterControlFactory : DockPanelExtender.IWindowSplitterControlFactory
    {
        public SplitterBase CreateSplitterControl(ISplitterHost host)
        {
            return new WindowSplitterControl(host);
        }
    }
}
