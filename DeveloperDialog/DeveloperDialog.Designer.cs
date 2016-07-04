namespace Handy.GUI
{
    partial class DeveloperDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloperDialog));
            this.Image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BlogTistory = new System.Windows.Forms.LinkLabel();
            this.BlogNaver = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
            this.Image.Location = new System.Drawing.Point(12, 12);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(150, 160);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "한 도영(DoYeong Han)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "rbfwmqwntm@naver.com";
            // 
            // BlogTistory
            // 
            this.BlogTistory.AutoSize = true;
            this.BlogTistory.Location = new System.Drawing.Point(168, 82);
            this.BlogTistory.Name = "BlogTistory";
            this.BlogTistory.Size = new System.Drawing.Size(143, 12);
            this.BlogTistory.TabIndex = 6;
            this.BlogTistory.TabStop = true;
            this.BlogTistory.Text = "http://hdnua.tistory.com";
            this.BlogTistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BlogTistory_LinkClicked);
            // 
            // BlogNaver
            // 
            this.BlogNaver.AutoSize = true;
            this.BlogNaver.Location = new System.Drawing.Point(168, 105);
            this.BlogNaver.Name = "BlogNaver";
            this.BlogNaver.Size = new System.Drawing.Size(208, 12);
            this.BlogNaver.TabIndex = 7;
            this.BlogNaver.TabStop = true;
            this.BlogNaver.Text = "http://blog.naver.com/rbfwmqwntm";
            this.BlogNaver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BlogNaver_LinkClicked);
            // 
            // DeveloperDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 184);
            this.Controls.Add(this.BlogNaver);
            this.Controls.Add(this.BlogTistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeveloperDialog";
            this.Text = "한 도영의 웹 에디터를 만든 사람";
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel BlogTistory;
        private System.Windows.Forms.LinkLabel BlogNaver;
    }
}