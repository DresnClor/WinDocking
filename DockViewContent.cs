using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinDocking.Docking;

namespace WinDocking
{
    /// <summary>
    /// 停靠视图窗体
    /// </summary>
    public class DockViewContent : DockContent
    {
        public DockViewContent()
        {
            this.HideOnClose = true;

        }

        /// <summary>
        /// 停靠视图区别名称
        /// </summary>
        public string ViewName
        {
            get;
            set;
        }
        /// <summary>
        /// 创建停靠视图菜单
        /// </summary>
        /// <param name="flat">浮动项文本</param>
        /// <param name="dock">停靠项文本</param>
        /// <param name="hide">自动隐藏项文本</param>
        /// <param name="doc">文档停靠项文本</param>
        /// <param name="close">关闭项文本</param>
        protected void CreatePopupMenu(string flat = "浮动", string dock = "停靠", string hide = "自动隐藏", string doc = "以文档方式停靠", string close = "关闭")
        {
            System.Windows.Forms.ContextMenuStrip popupMenu = new System.Windows.Forms.ContextMenuStrip();

            popupMenu.Items.Add(flat, null, (sender, e) =>
            {
                this.DockState = DockState.Float;
            });

            popupMenu.Items.Add(dock, null, (sender, e) =>
            {
                if(this.DockState== DockState.Float)
                {
                    this.DockState = this.DefaultDockState;
                }
                else
                {
                    this.DockState = this.GetNormal();
                }
            });
            popupMenu.Items.Add(hide, null, (sender, e) =>
            {
                this.DockState = this.GetAutoHide();
            });
            popupMenu.Items.Add(new System.Windows.Forms.ToolStripSeparator());
            popupMenu.Items.Add(doc, null, (sender, e) =>
            {
                this.DockState = DockState.Document;
            });
            popupMenu.Items.Add(close, null, (sender, e) =>
            {
                this.Hide();
            });
            this.TabPageContextMenuStrip = popupMenu;
        }

    }
}
