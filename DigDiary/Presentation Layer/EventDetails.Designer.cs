
namespace DigDiary.Presentation_Layer
{
    partial class EventDetails
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
            this.detailsEventTitleTextBox = new System.Windows.Forms.TextBox();
            this.detailsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // detailsEventTitleTextBox
            // 
            this.detailsEventTitleTextBox.Location = new System.Drawing.Point(168, 53);
            this.detailsEventTitleTextBox.Name = "detailsEventTitleTextBox";
            this.detailsEventTitleTextBox.Size = new System.Drawing.Size(262, 20);
            this.detailsEventTitleTextBox.TabIndex = 0;
            // 
            // detailsDescriptionTextBox
            // 
            this.detailsDescriptionTextBox.Location = new System.Drawing.Point(168, 129);
            this.detailsDescriptionTextBox.Name = "detailsDescriptionTextBox";
            this.detailsDescriptionTextBox.Size = new System.Drawing.Size(262, 20);
            this.detailsDescriptionTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 666);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detailsDescriptionTextBox);
            this.Controls.Add(this.detailsEventTitleTextBox);
            this.Name = "EventDetails";
            this.Text = "EventDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventDetails_FormClosing);
            this.Load += new System.EventHandler(this.EventDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox detailsEventTitleTextBox;
        private System.Windows.Forms.TextBox detailsDescriptionTextBox;
        private System.Windows.Forms.Label label1;
    }
}