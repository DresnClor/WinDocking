using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDocking
{
    /// <summary>
    /// 文档视图编辑动作枚举
    /// </summary>
    public enum EditAction
    {
        /// <summary>
        /// 无任何操作
        /// </summary>
        Null=-1,
        //---------------基础编辑---------------
        /// <summary>
        /// 撤销
        /// </summary>
        Undo,
        /// <summary>
        /// 重做
        /// </summary>
        Redo,
        /// <summary>
        /// 剪切
        /// </summary>
        Cut,
        /// <summary>
        /// 复制
        /// </summary>
        Copy,
        /// <summary>
        /// 粘贴
        /// </summary>
        Paste,
        /// <summary>
        /// 删除
        /// </summary>
        Delete,
        /// <summary>
        /// 全选
        /// </summary>
        SelectAll,
        /// <summary>
        /// 将文件作为文本插入
        /// </summary>
        InsertText,
        //---------------代码编辑---------------
        /// <summary>
        /// 转到
        /// </summary>
        Goto,
        /// <summary>
        /// 转到行
        /// </summary>
        GotoLine,
        /// <summary>
        /// 转到行尾
        /// </summary>
        GotoEndOfLine,
        /// <summary>
        /// 转到行首
        /// </summary>
        GotoBeginOfLine,
        /// <summary>
        /// 转到符号
        /// </summary>
        GotoSymbol,
        /// <summary>
        /// 将选定行中的空格替换为制表符
        /// </summary>
        SelectRowSpaceWithTabs,
        /// <summary>
        /// 将选定行中的制表符替换为空格
        /// </summary>
        SelectRowTabsWithSpace,
        /// <summary>
        /// 将选定行上移
        /// </summary>
        MoveUpSelectRow,
        /// <summary>
        /// 将选定行下移
        /// </summary>
        MoveDownSelectRow,
        /// <summary>
        /// 转为大写
        /// </summary>
        ConvertUpper,
        /// <summary>
        /// 转为小写
        /// </summary>
        ConvertLower,
        /// <summary>
        /// 查看空白
        /// </summary>
        ViewTextBlank,
        /// <summary>
        /// 自动换行
        /// </summary>
        AutoWrap,
        /// <summary>
        /// 注释选定内容
        /// </summary>
        CommentSelect,
        /// <summary>
        /// 取消注释选定内容
        /// </summary>
        UncommentSelect,
        /// <summary>
        /// 增加行缩进
        /// </summary>
        IncreaseIndent,
        /// <summary>
        /// 减少行缩进
        /// </summary>
        DecreaseIndent,
        /// <summary>
        /// 设置行尾序列
        /// </summary>
        SetLineSequence,
        /// <summary>
        /// 设置缩进
        /// </summary>
        SetIndent,
        /// <summary>
        /// 切换书签
        /// </summary>
        ToggleBookmarks,
        /// <summary>
        /// 上一个书签
        /// </summary>
        PrevBookmark,
        /// <summary>
        /// 下一个书签
        /// </summary>
        NextBookmark,
        /// <summary>
        /// 清除书签
        /// </summary>
        ClearBookmark,
        //---------------项目数据传递---------------

    }
}
