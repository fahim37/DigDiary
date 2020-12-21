
namespace DigDiary.Presentation_Layer
{
    partial class Events
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
            this.titleDateDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.createEventbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toModifyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modifyOpenButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ViewEventButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.viewEventTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.titleDateDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleDateDataGridView
            // 
            this.titleDateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.titleDateDataGridView.Location = new System.Drawing.Point(40, 68);
            this.titleDateDataGridView.Name = "titleDateDataGridView";
            this.titleDateDataGridView.Size = new System.Drawing.Size(275, 331);
            this.titleDateDataGridView.TabIndex = 0;
            this.titleDateDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.titleDateDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Events";
            // 
            // createEventbutton
            // 
            this.createEventbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createEventbutton.Location = new System.Drawing.Point(422, 68);
            this.createEventbutton.Name = "createEventbutton";
            this.createEventbutton.Size = new System.Drawing.Size(295, 68);
            this.createEventbutton.TabIndex = 2;
            this.createEventbutton.Text = "Create New Event";
            this.createEventbutton.UseVisualStyleBackColor = true;
            this.createEventbutton.Click += new System.EventHandler(this.createEventbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modifyOpenButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.toModifyTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(380, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify Event";
            // 
            // toModifyTextBox
            // 
            this.toModifyTextBox.Location = new System.Drawing.Point(102, 54);
            this.toModifyTextBox.Name = "toModifyTextBox";
            this.toModifyTextBox.Size = new System.Drawing.Size(243, 22);
            this.toModifyTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Title";
            // 
            // modifyOpenButton
            // 
            this.modifyOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyOpenButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.modifyOpenButton.Location = new System.Drawing.Point(102, 105);
            this.modifyOpenButton.Name = "modifyOpenButton";
            this.modifyOpenButton.Size = new System.Drawing.Size(242, 39);
            this.modifyOpenButton.TabIndex = 2;
            this.modifyOpenButton.Text = "Open";
            this.modifyOpenButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ViewEventButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.viewEventTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(380, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 182);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Event Details";
            // 
            // ViewEventButton
            // 
            this.ViewEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEventButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ViewEventButton.Location = new System.Drawing.Point(102, 105);
            this.ViewEventButton.Name = "ViewEventButton";
            this.ViewEventButton.Size = new System.Drawing.Size(242, 39);
            this.ViewEventButton.TabIndex = 2;
            this.ViewEventButton.Text = "Open";
            this.ViewEventButton.UseVisualStyleBackColor = true;
            this.ViewEventButton.Click += new System.EventHandler(this.ViewEventButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Event Title";
            // 
            // viewEventTextBox
            // 
            this.viewEventTextBox.Location = new System.Drawing.Point(102, 54);
            this.viewEventTextBox.Name = "viewEventTextBox";
            this.viewEventTextBox.Size = new System.Drawing.Size(243, 22);
            this.viewEventTextBox.TabIndex = 0;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createEventbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleDateDataGridView);
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Events_FormClosing);
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titleDateDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView titleDateDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createEventbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button modifyOpenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toModifyTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ViewEventButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox viewEventTextBox;
    }
}