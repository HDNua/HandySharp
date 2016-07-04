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
    /// 사용자로부터 문자열을 입력 받는 PromptDialog 객체를 생성합니다.
    /// </summary>
    public partial class PromptDialog : Form
    {
        public string Input { get; set; }

        /// <summary>
        /// 사용자로부터 문자열을 입력 받는 PromptDialog 객체를 생성합니다.
        /// </summary>
        /// <param name="message">사용자에게 표시할 설명입니다.</param>
        /// <returns>확인 버튼을 누른 경우 TextBox 객체의 문자열, 그 외의 경우 null을 반환합니다.</returns>
        public static string ShowForm(string message)
        {
            PromptDialog dialog = new PromptDialog(message);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.Input;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// PromptDialog 객체를 생성합니다.
        /// </summary>
        /// <param name="message">사용자에게 표시할 설명입니다.</param>
        public PromptDialog(string message)
        {
            InitializeComponent();
            this.MessageLabel.Text = message;
            this.Text = Lang.Title;
            this.button1.Text = Lang.ButtonAccept;
            this.button2.Text = Lang.ButtonCancel;
        }

        #region Inner Methods Implementation
        void OnAccept()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Input = this.MessageInput.Text;
            this.Close();
        }
        void OnCancel()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Input = string.Empty;
            this.Close();
        }
        void OnPromptKeyDown(KeyEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            OnAccept();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OnCancel();
        }

        private void PromptDialog_KeyDown(object sender, KeyEventArgs e)
        {
            OnPromptKeyDown(e);
        }

        private void MessageInput_KeyDown(object sender, KeyEventArgs e)
        {
            OnPromptKeyDown(e);
        }
        #endregion Inner Methods Implementation

    }
}
