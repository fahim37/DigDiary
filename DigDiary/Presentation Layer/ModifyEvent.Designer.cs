
namespace DigDiary.Presentation_Layer
{
    partial class ModifyEvent
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
            this.modifyButton = new System.Windows.Forms.Button();
            this.modifyDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.modifyMoodComboBox = new System.Windows.Forms.ComboBox();
            this.modifyImportanceComboBox = new System.Windows.Forms.ComboBox();
            this.modifyTitleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.modifyButton.Location = new System.Drawing.Point(235, 475);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(131, 55);
            this.modifyButton.TabIndex = 25;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // modifyDescriptionTextBox
            // 
            this.modifyDescriptionTextBox.Location = new System.Drawing.Point(139, 115);
            this.modifyDescriptionTextBox.Multiline = true;
            this.modifyDescriptionTextBox.Name = "modifyDescriptionTextBox";
            this.modifyDescriptionTextBox.Size = new System.Drawing.Size(404, 198);
            this.modifyDescriptionTextBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(46, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Importance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(46, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mood :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(46, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Modified on :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(46, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Event Title :";
            // 
            // modifyDateTimePicker
            // 
            this.modifyDateTimePicker.Location = new System.Drawing.Point(143, 336);
            this.modifyDateTimePicker.Name = "modifyDateTimePicker";
            this.modifyDateTimePicker.Size = new System.Drawing.Size(256, 20);
            this.modifyDateTimePicker.TabIndex = 27;
            // 
            // modifyMoodComboBox
            // 
            this.modifyMoodComboBox.FormattingEnabled = true;
            this.modifyMoodComboBox.Items.AddRange(new object[] {
            "Happy",
            "Sad",
            "Excited",
            "Joy"});
            this.modifyMoodComboBox.Location = new System.Drawing.Point(143, 380);
            this.modifyMoodComboBox.Name = "modifyMoodComboBox";
            this.modifyMoodComboBox.Size = new System.Drawing.Size(256, 21);
            this.modifyMoodComboBox.TabIndex = 28;
            // 
            // modifyImportanceComboBox
            // 
            this.modifyImportanceComboBox.FormattingEnabled = true;
            this.modifyImportanceComboBox.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less"});
            this.modifyImportanceComboBox.Location = new System.Drawing.Point(143, 424);
            this.modifyImportanceComboBox.Name = "modifyImportanceComboBox";
            this.modifyImportanceComboBox.Size = new System.Drawing.Size(256, 21);
            this.modifyImportanceComboBox.TabIndex = 29;
            // 
            // modifyTitleTextBox
            // 
            this.modifyTitleTextBox.Location = new System.Drawing.Point(134, 63);
            this.modifyTitleTextBox.Name = "modifyTitleTextBox";
            this.modifyTitleTextBox.Size = new System.Drawing.Size(409, 20);
            this.modifyTitleTextBox.TabIndex = 31;
            // 
            // ModifyEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 615);
            this.Controls.Add(this.modifyTitleTextBox);
            this.Controls.Add(this.modifyImportanceComboBox);
            this.Controls.Add(this.modifyMoodComboBox);
            this.Controls.Add(this.modifyDateTimePicker);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.modifyDescriptionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyEvent_FormClosing);
            this.Load += new System.EventHandler(this.ModifyEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.TextBox modifyDescriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker modifyDateTimePicker;
        private System.Windows.Forms.ComboBox modifyMoodComboBox;
        private System.Windows.Forms.ComboBox modifyImportanceComboBox;
        private System.Windows.Forms.TextBox modifyTitleTextBox;
    }
}