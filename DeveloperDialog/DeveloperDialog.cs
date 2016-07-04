using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace Handy.GUI
{
    /// <summary>
    /// 개발자의 정보를 다이얼로그로 표시합니다.
    /// </summary>
    public partial class DeveloperDialog : Form
    {
        /// <summary>
        /// 개발자의 정보를 다이얼로그로 표시합니다.
        /// </summary>
        public static void ShowForm()
        {
            DeveloperDialog dialog = new DeveloperDialog();
            dialog.ShowDialog();
        }

        /// <summary>
        /// DeveloperDialog 객체의 생성자입니다.
        /// </summary>
        public DeveloperDialog()
        {
            InitializeComponent();
            this.Text = Lang.Title;
            this.button1.Text = Lang.ButtonClose;
        }

        #region Inner Methods Implementation
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlogTistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.LinkData = BlogTistory.Text;
            Process.Start(e.Link.LinkData.ToString());
        }

        private void BlogNaver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.LinkData = BlogNaver.Text;
            Process.Start(e.Link.LinkData.ToString());
        }
        #endregion Inner Methods Implementation
    }
}
