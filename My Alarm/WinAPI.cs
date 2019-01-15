using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace My_Alarm
{
    /// <summary>
    /// 提供一系列Win32 API函数
    /// </summary>
    class WinAPI
    {
        /// <summary>
        /// 预定义的热键值
        /// </summary>
        public const int WM_HOTKEY = 0x0312;
        /// <summary>
        /// 注册全局快捷键
        /// </summary>
        /// <param name="hWnd">响应该热键的窗口句柄，为null，则与当前线程相关联</param>
        /// <param name="id">该热键的唯一标识符</param>
        /// <param name="fsModifiers">辅助按键，修饰键</param>
        /// <param name="vk">虚拟键代码</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, UInt32 fsModifiers, UInt32 vk);

        /// <summary>
        /// 全局热键的注销
        /// </summary>
        /// <param name="hWnd">要注销热键的窗口</param>
        /// <param name="id">该热键的全局标识符</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// 修饰键
        /// </summary>
        public enum ModifierKeys : uint
        {
            Alt = 0x0001,
            Control = 0x0002,
            Shift = 0x0004,
            Windows = 0x0008
        }
    }
}
