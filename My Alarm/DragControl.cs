using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DragControl
{
    class DragControl : Component
    {
        private Control handleControl;

        [Description("选择一个控件，以允许拖动此控件来拖动窗体")]
        public Control SelectControl
        {
            get
            {
                return handleControl;
            }
            set
            {
                handleControl = value;
                handleControl.MouseDown += new MouseEventHandler(this.Dragform_MouseDown);
            }
        }

        [DllImport("user32.dll")]
        public extern static int SendMessage(IntPtr a, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Dragform_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if(flag)
            {
                ReleaseCapture();
                SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}
