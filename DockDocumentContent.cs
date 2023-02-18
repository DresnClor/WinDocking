using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinDocking.Docking;
using System.Windows.Forms;
using System.IO;

namespace WinDocking
{
    /// <summary>
    /// 停靠文档窗体
    /// </summary>
    public class DockDocumentContent : DockContent
    {
        public DockDocumentContent()
        {
            this.FormClosing += this.DockDocumentContent_FormClosing;
        }

        private void DockDocumentContent_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// 文档名称，用于存放在集合里的键名
        /// </summary>
        public virtual string DocumentName
        {
            get;
            set;
        }

        /// <summary>
        /// 文档文件路径
        /// </summary>
        public virtual string FilePath
        {
            get;
            set;
        }

        /// <summary>
        /// 是否已保存文件，为true则文件保存，为false则文件没有保存
        /// </summary>
        public virtual bool FileIsSave
        {
            get { return this._isSave; }
            set
            {
                if (this._isSave == value)
                    return;
                this._isSave = value;
                if (this._isSave)
                {
                    this.Title = this.Title?.Replace("*", "");
                }
                else
                {
                    this.Title = this.Title != null ? this.Title + "*" : "*";
                }
            }
        }
        bool _isSave = true;

        /// <summary>
        /// 关闭文档视图
        /// </summary>
        /// <param name="saveFile">是否保存文件</param>
        public virtual void CloseDocumentView(bool saveFile)
        {
            if (saveFile)
            {
                this.SaveDocument();
                this.FileIsSave = true;
            }
            else
            {
                this.FileIsSave = true;
            }
            this.Close();
        }

        /// <summary>
        /// 编辑操作
        /// </summary>
        /// <param name="edit">枚举编辑动作</param>
        /// <param name="data">数据列表</param>
        public virtual void EditOperation(EditAction edit, params object[] data)
        {

        }

        /// <summary>
        /// 隐藏视图
        /// </summary>
        public virtual void HideView()
        {
            this.Hide();
        }

        /// <summary>
        /// 加载文档
        /// </summary>
        /// <param name="path">文档文件路径</param>
        public virtual void LoadDocument(string path)
        {
            this.FilePath = path;
            this.Title = Path.GetFileName(this.FilePath);
            this.DocumentName = this.FilePath;
        }

        /// <summary>
        /// 加载文档
        /// </summary>
        /// <param name="path">文档文件路径</param>
        /// <param name="prj">项目实例</param>
        public virtual void LoadDocument(string path,object prj)
        {
            this.FilePath = path;
            this.Title = Path.GetFileName(this.FilePath);
            this.DocumentName = this.FilePath;
        }

        /// <summary>
        /// 重命名文档
        /// </summary>
        /// <param name="newName">新名称</param>
        public virtual void RenameDocument(string newName)
        {

        }

        /// <summary>
        /// 另存为文档
        /// </summary>
        /// <param name="path">另存为路径</param>
        public virtual void SaveAsDocument(string path)
        {

        }

        /// <summary>
        /// 保存文档
        /// </summary>
        public virtual void SaveDocument()
        {

        }

    }
}
