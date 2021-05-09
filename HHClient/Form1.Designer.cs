
namespace HHClient {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.HHGet = new System.Windows.Forms.Button();
            this.JsonArea = new System.Windows.Forms.RichTextBox();
            this.SearchString = new System.Windows.Forms.TextBox();
            this.CookieArea = new System.Windows.Forms.RichTextBox();
            this.HeadersArea = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HHGet
            // 
            this.HHGet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HHGet.Location = new System.Drawing.Point(461, 419);
            this.HHGet.Name = "HHGet";
            this.HHGet.Size = new System.Drawing.Size(123, 23);
            this.HHGet.TabIndex = 0;
            this.HHGet.Text = "HHGet";
            this.HHGet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HHGet.UseVisualStyleBackColor = true;
            this.HHGet.Click += new System.EventHandler(this.HHGet_Click);
            // 
            // JsonArea
            // 
            this.JsonArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JsonArea.Location = new System.Drawing.Point(12, 12);
            this.JsonArea.Name = "JsonArea";
            this.JsonArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.JsonArea.Size = new System.Drawing.Size(572, 400);
            this.JsonArea.TabIndex = 1;
            this.JsonArea.Text = "";
            // 
            // SearchString
            // 
            this.SearchString.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchString.Location = new System.Drawing.Point(12, 418);
            this.SearchString.Name = "SearchString";
            this.SearchString.Size = new System.Drawing.Size(443, 23);
            this.SearchString.TabIndex = 2;
            this.SearchString.Text = "https://api.hh.ru/vacancies/?text=программист&per_page=100";
            // 
            // CookieArea
            // 
            this.CookieArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CookieArea.Location = new System.Drawing.Point(12, 456);
            this.CookieArea.Name = "CookieArea";
            this.CookieArea.Size = new System.Drawing.Size(443, 321);
            this.CookieArea.TabIndex = 3;
            this.CookieArea.Text = "";
            // 
            // HeadersArea
            // 
            this.HeadersArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeadersArea.Location = new System.Drawing.Point(590, 12);
            this.HeadersArea.Name = "HeadersArea";
            this.HeadersArea.Size = new System.Drawing.Size(589, 189);
            this.HeadersArea.TabIndex = 4;
            this.HeadersArea.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.AcceptsTab = true;
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.AutoWordSelection = true;
            this.richTextBox2.EnableAutoDragDrop = true;
            this.richTextBox2.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.richTextBox2.Location = new System.Drawing.Point(590, 207);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(589, 570);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            this.richTextBox2.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox2_LinkClicked);
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(462, 456);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(122, 23);
            this.AuthButton.TabIndex = 6;
            this.AuthButton.Text = "Auth";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 789);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.HeadersArea);
            this.Controls.Add(this.CookieArea);
            this.Controls.Add(this.SearchString);
            this.Controls.Add(this.JsonArea);
            this.Controls.Add(this.HHGet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HHGet;
        private System.Windows.Forms.RichTextBox JsonArea;
        private System.Windows.Forms.TextBox SearchString;
        private System.Windows.Forms.RichTextBox CookieArea;
        private System.Windows.Forms.RichTextBox HeadersArea;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button AuthButton;
    }
}

