using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handy.GUI
{
    /// <summary>
    /// 사용자에게 과정을 진행할 것인지 확인하는 ConfirmDialog를 생성합니다.
    /// </summary>
    public partial class ConfirmDialog : Form
    {
        /// <summary>
        /// 사용자에게 과정을 진행할 것인지 확인하는 ConfirmDialog를 생성합니다.
        /// </summary>
        /// <param name="message">사용자에게 표시할 설명입니다.</param>
        /// <returns>사용자가 확인 버튼을 누른 경우 DialogResult.OK, 그 외의 경우는 DialogResult.OK가 아닌 값을 반환합니다.</returns>
        public static DialogResult ShowForm(string message)
        {
            ConfirmDialog dialog = new ConfirmDialog(message);
            return dialog.ShowDialog();
        }

        /// <summary>
        /// ConfirmDialog 객체를 생성합니다.
        /// </summary>
        /// <param name="message">사용자에게 표시할 설명합니다.</param>
        public ConfirmDialog(string message)
        {
            InitializeComponent();
            this.MessageLabel.Text = message;
            this.Text = Lang.Title;
        }

        #region Inner Methods Implementation
        void OnAccept()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }
        void OnCancel()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnAccept();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OnCancel();
        }

        private void ConfirmDialog_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Enter:
                    OnAccept();
                    break;
                case Keys.Escape:
                    OnCancel();
                    break;
            }
        }
        #endregion Inner Methods Implementation

    }
}
