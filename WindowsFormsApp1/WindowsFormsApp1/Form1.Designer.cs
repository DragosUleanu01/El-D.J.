namespace WindowsFormsApp1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Lista = new System.Windows.Forms.ListBox();
            this.Link_Label = new System.Windows.Forms.Label();
            this.Gen_Label = new System.Windows.Forms.Label();
            this.Featuring_Label = new System.Windows.Forms.Label();
            this.Artist_Label = new System.Windows.Forms.Label();
            this.Nume_Label = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Afisare = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Lista);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.Link_Label);
            this.splitContainer1.Panel2.Controls.Add(this.Gen_Label);
            this.splitContainer1.Panel2.Controls.Add(this.Featuring_Label);
            this.splitContainer1.Panel2.Controls.Add(this.Artist_Label);
            this.splitContainer1.Panel2.Controls.Add(this.Nume_Label);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox2);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel2.Controls.Add(this.Afisare);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // Lista
            // 
            this.Lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(0, 0);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(222, 455);
            this.Lista.TabIndex = 0;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // Link_Label
            // 
            this.Link_Label.AutoSize = true;
            this.Link_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Label.Location = new System.Drawing.Point(61, 191);
            this.Link_Label.Name = "Link_Label";
            this.Link_Label.Size = new System.Drawing.Size(49, 24);
            this.Link_Label.TabIndex = 8;
            this.Link_Label.Text = "Link:";
            // 
            // Gen_Label
            // 
            this.Gen_Label.AutoSize = true;
            this.Gen_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gen_Label.Location = new System.Drawing.Point(61, 154);
            this.Gen_Label.Name = "Gen_Label";
            this.Gen_Label.Size = new System.Drawing.Size(51, 24);
            this.Gen_Label.TabIndex = 7;
            this.Gen_Label.Text = "Gen:";
            // 
            // Featuring_Label
            // 
            this.Featuring_Label.AutoSize = true;
            this.Featuring_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Featuring_Label.Location = new System.Drawing.Point(61, 117);
            this.Featuring_Label.Name = "Featuring_Label";
            this.Featuring_Label.Size = new System.Drawing.Size(95, 24);
            this.Featuring_Label.TabIndex = 6;
            this.Featuring_Label.Text = "Featuring:";
            // 
            // Artist_Label
            // 
            this.Artist_Label.AutoSize = true;
            this.Artist_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist_Label.Location = new System.Drawing.Point(61, 80);
            this.Artist_Label.Name = "Artist_Label";
            this.Artist_Label.Size = new System.Drawing.Size(112, 24);
            this.Artist_Label.TabIndex = 5;
            this.Artist_Label.Text = "Nume Artist:";
            this.Artist_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Nume_Label
            // 
            this.Nume_Label.AutoSize = true;
            this.Nume_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume_Label.Location = new System.Drawing.Point(61, 40);
            this.Nume_Label.Name = "Nume_Label";
            this.Nume_Label.Size = new System.Drawing.Size(67, 24);
            this.Nume_Label.TabIndex = 3;
            this.Nume_Label.Text = "Nume:";
            this.Nume_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(373, 412);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Artisti";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(373, 373);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Melodii";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Afisare
            // 
            this.Afisare.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afisare.Location = new System.Drawing.Point(189, 373);
            this.Afisare.Name = "Afisare";
            this.Afisare.Size = new System.Drawing.Size(147, 65);
            this.Afisare.TabIndex = 0;
            this.Afisare.Text = "Afisare";
            this.Afisare.UseVisualStyleBackColor = true;
            this.Afisare.Click += new System.EventHandler(this.Afisare_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(118, 199);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "El D.J. Definitive";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Afisare;
        private System.Windows.Forms.Label Link_Label;
        private System.Windows.Forms.Label Gen_Label;
        private System.Windows.Forms.Label Featuring_Label;
        private System.Windows.Forms.Label Artist_Label;
        private System.Windows.Forms.Label Nume_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

