namespace Speech_To_Text
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
            this.rbSpeech = new System.Windows.Forms.RadioButton();
            this.rbTranslation = new System.Windows.Forms.RadioButton();
            this.cbCopyText = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbShowText = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.buttStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSpeech
            // 
            this.rbSpeech.AutoSize = true;
            this.rbSpeech.Location = new System.Drawing.Point(8, 17);
            this.rbSpeech.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSpeech.Name = "rbSpeech";
            this.rbSpeech.Size = new System.Drawing.Size(62, 17);
            this.rbSpeech.TabIndex = 0;
            this.rbSpeech.TabStop = true;
            this.rbSpeech.Text = "Speech";
            this.rbSpeech.UseVisualStyleBackColor = true;
            // 
            // rbTranslation
            // 
            this.rbTranslation.AutoSize = true;
            this.rbTranslation.Location = new System.Drawing.Point(8, 37);
            this.rbTranslation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTranslation.Name = "rbTranslation";
            this.rbTranslation.Size = new System.Drawing.Size(82, 17);
            this.rbTranslation.TabIndex = 1;
            this.rbTranslation.TabStop = true;
            this.rbTranslation.Text = "Translation";
            this.rbTranslation.UseVisualStyleBackColor = true;
            // 
            // cbCopyText
            // 
            this.cbCopyText.AutoSize = true;
            this.cbCopyText.Location = new System.Drawing.Point(8, 17);
            this.cbCopyText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCopyText.Name = "cbCopyText";
            this.cbCopyText.Size = new System.Drawing.Size(75, 17);
            this.cbCopyText.TabIndex = 3;
            this.cbCopyText.Text = "Copy Text";
            this.cbCopyText.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSpeech);
            this.groupBox1.Controls.Add(this.rbTranslation);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(120, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCopyText);
            this.groupBox2.Controls.Add(this.cbShowText);
            this.groupBox2.Location = new System.Drawing.Point(159, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(120, 64);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // cbShowText
            // 
            this.cbShowText.AutoSize = true;
            this.cbShowText.Location = new System.Drawing.Point(8, 38);
            this.cbShowText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbShowText.Name = "cbShowText";
            this.cbShowText.Size = new System.Drawing.Size(78, 17);
            this.cbShowText.TabIndex = 4;
            this.cbShowText.Text = "Show Text";
            this.cbShowText.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbTo);
            this.groupBox3.Controls.Add(this.cbFrom);
            this.groupBox3.Location = new System.Drawing.Point(5, 77);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(283, 47);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Languages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // cbTo
            // 
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(154, 16);
            this.cbTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 21);
            this.cbTo.TabIndex = 1;
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(7, 16);
            this.cbFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(120, 21);
            this.cbFrom.TabIndex = 0;
            // 
            // buttStart
            // 
            this.buttStart.Location = new System.Drawing.Point(105, 133);
            this.buttStart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttStart.Name = "buttStart";
            this.buttStart.Size = new System.Drawing.Size(74, 22);
            this.buttStart.TabIndex = 7;
            this.buttStart.Text = "Start";
            this.buttStart.UseVisualStyleBackColor = true;
            this.buttStart.Click += new System.EventHandler(this.buttStart_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 169);
            this.Controls.Add(this.buttStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Speech To Text";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSpeech;
        private System.Windows.Forms.RadioButton rbTranslation;
        private System.Windows.Forms.CheckBox cbCopyText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbShowText;
        private System.Windows.Forms.Button buttStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

