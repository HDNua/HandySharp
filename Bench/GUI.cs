using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Handy.GUI;

namespace Bench
{
    public static class GUI
    {
        public static void ConfirmDialogMain()
        {
            ConfirmDialog dialog = null;
            DialogResult result;

            dialog = new ConfirmDialog("message");
            result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("success!");
            }

        }
        public static void DeveloperDialogMain()
        {
            DeveloperDialog dialog = null;
            DialogResult result;

            dialog = new DeveloperDialog();
            result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("success!");
            }
        }
        public static void PromptDialogMain()
        {
            PromptDialog dialog = null;
            DialogResult result;

            dialog = new PromptDialog("TEST");
            result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("success! " + dialog.Input);
            }
        }
    }
}
