namespace WinDocking.Themes
{
	using Docking;
	using System.IO;

	/// <summary>
	/// Visual Studio 2015 theme base.
	/// </summary>
	public abstract class VThemeBase : ThemeBase
	{
		public VThemeBase(byte[] resources)
		{
			ColorPalette = new DockPanelColorPalette(new PaletteFactory(resources));
			Skin = new DockPanelSkin();
			PaintingService = new PaintingService();
			ImageService = new ImageService(this);
			ToolStripRenderer = new VToolStripRenderer(ColorPalette)
			{
				UseGlassOnMenuStrip = false,
			};
			Measures.SplitterSize = 6;
			Measures.AutoHideSplitterSize = 3;
			Measures.DockPadding = 6;
			ShowAutoHideContentOnHover = false;
			Extender.AutoHideStripFactory = new AutoHideStripFactory();
			Extender.AutoHideWindowFactory = new AutoHideWindowFactory();
			Extender.DockPaneFactory = new DockPaneFactory();
			Extender.DockPaneCaptionFactory = new DockPaneCaptionFactory();
			Extender.DockPaneStripFactory = new DockPaneStripFactory();
			Extender.DockPaneSplitterControlFactory = new DockPaneSplitterControlFactory();
			Extender.WindowSplitterControlFactory = new WindowSplitterControlFactory();
			Extender.DockWindowFactory = new DockWindowFactory();
			Extender.PaneIndicatorFactory = new PaneIndicatorFactory();
			Extender.PanelIndicatorFactory = new PanelIndicatorFactory();
			Extender.DockOutlineFactory = new DockOutlineFactory();
			Extender.DockIndicatorFactory = new DockIndicatorFactory();
		}

		public VThemeBase(string file)
		{
			byte[] bs = File.ReadAllBytes(file);
			ColorPalette = new DockPanelColorPalette(new PaletteFactory(bs));
			Skin = new DockPanelSkin();
			PaintingService = new PaintingService();
			ImageService = new ImageService(this);
			ToolStripRenderer = new VToolStripRenderer(ColorPalette)
			{
				UseGlassOnMenuStrip = false,
			};
			Measures.SplitterSize = 6;
			Measures.AutoHideSplitterSize = 3;
			Measures.DockPadding = 6;
			ShowAutoHideContentOnHover = false;
			Extender.AutoHideStripFactory = new AutoHideStripFactory();
			Extender.AutoHideWindowFactory = new AutoHideWindowFactory();
			Extender.DockPaneFactory = new DockPaneFactory();
			Extender.DockPaneCaptionFactory = new DockPaneCaptionFactory();
			Extender.DockPaneStripFactory = new DockPaneStripFactory();
			Extender.DockPaneSplitterControlFactory = new DockPaneSplitterControlFactory();
			Extender.WindowSplitterControlFactory = new WindowSplitterControlFactory();
			Extender.DockWindowFactory = new DockWindowFactory();
			Extender.PaneIndicatorFactory = new PaneIndicatorFactory();
			Extender.PanelIndicatorFactory = new PanelIndicatorFactory();
			Extender.DockOutlineFactory = new DockOutlineFactory();
			Extender.DockIndicatorFactory = new DockIndicatorFactory();
		}


		public override void CleanUp(DockPanel dockPanel)
		{
			PaintingService.CleanUp();
			base.CleanUp(dockPanel);
		}
	}
}
