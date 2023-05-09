namespace WindowsFormsApp1
{
    partial class Form2
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
            this.Lista2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista2
            // 
            this.Lista2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lista2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lista2.FormattingEnabled = true;
            this.Lista2.Location = new System.Drawing.Point(137, 22);
            this.Lista2.Name = "Lista2";
            this.Lista2.Size = new System.Drawing.Size(495, 379);
            this.Lista2.TabIndex = 0;
            this.Lista2.SelectedIndexChanged += new System.EventHandler(this.Lista2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lista2);
            this.Name = "Form2";
            this.Text = "Melodii";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista2;
        private System.Windows.Forms.Button button1;
    }
}