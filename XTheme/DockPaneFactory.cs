﻿using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using WinDocking.Docking;

namespace WinDocking.Themes
{
    public class DockPaneFactory : DockPanelExtender.IDockPaneFactory
    {
        public DockPane CreateDockPane(IDockContent content, DockState visibleState, bool show)
        {
            return new DockPane(content, visibleState, show);
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:AvoidTypeNamesInParameters", MessageId = "1#")]
        public DockPane CreateDockPane(IDockContent content, FloatWindow floatWindow, bool show)
        {
            return new DockPane(content, floatWindow, show);
        }

        public DockPane CreateDockPane(IDockContent content, DockPane previousPane, DockAlignment alignment, double proportion, bool show)
        {
            return new DockPane(content, previousPane, alignment, proportion, show);
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:AvoidTypeNamesInParameters", MessageId = "1#")]
        public DockPane CreateDockPane(IDockContent content, Rectangle floatWindowBounds, bool show)
        {
            return new DockPane(content, floatWindowBounds, show);
        }
    }
}
