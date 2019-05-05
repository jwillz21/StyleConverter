namespace StyleConverter
{
    partial class Form1
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
            this.RichTextbox = new System.Windows.Forms.RichTextBox();
            this.ConvertedTextbox = new System.Windows.Forms.RichTextBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RichTextbox
            // 
            this.RichTextbox.Location = new System.Drawing.Point(12, 54);
            this.RichTextbox.Name = "RichTextbox";
            this.RichTextbox.Size = new System.Drawing.Size(601, 743);
            this.RichTextbox.TabIndex = 0;
            this.RichTextbox.Text = "";
            // 
            // ConvertedTextbox
            // 
            this.ConvertedTextbox.Location = new System.Drawing.Point(822, 54);
            this.ConvertedTextbox.Name = "ConvertedTextbox";
            this.ConvertedTextbox.ReadOnly = true;
            this.ConvertedTextbox.Size = new System.Drawing.Size(601, 743);
            this.ConvertedTextbox.TabIndex = 1;
            this.ConvertedTextbox.Text = "";
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(648, 374);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(130, 36);
            this.ConvertBtn.TabIndex = 2;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rich Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1054, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 809);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.ConvertedTextbox);
            this.Controls.Add(this.RichTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextbox;
        private System.Windows.Forms.RichTextBox ConvertedTextbox;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

