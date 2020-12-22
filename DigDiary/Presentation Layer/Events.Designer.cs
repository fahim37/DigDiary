
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
            this.modifyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toModifyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ViewEventButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.viewEventTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteEventTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.titleDateDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleDateDataGridView
            // 
            this.titleDateDataGridView.AllowUserToAddRows = false;
            this.titleDateDataGridView.AllowUserToDeleteRows = false;
            this.titleDateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.titleDateDataGridView.Location = new System.Drawing.Point(40, 68);
            this.titleDateDataGridView.Name = "titleDateDataGridView";
            this.titleDateDataGridView.ReadOnly = true;
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
            this.groupBox1.Controls.Add(this.modifyButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.toModifyTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify Event";
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.modifyButton.Location = new System.Drawing.Point(102, 105);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(228, 39);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
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
            // toModifyTextBox
            // 
            this.toModifyTextBox.Location = new System.Drawing.Point(102, 54);
            this.toModifyTextBox.Name = "toModifyTextBox";
            this.toModifyTextBox.Size = new System.Drawing.Size(228, 22);
            this.toModifyTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ViewEventButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.viewEventTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(382, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 221);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Event Details";
            // 
            // ViewEventButton
            // 
            this.ViewEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEventButton.ForeColor = System.Drawing.SystemColors.Highlight;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.deleteEventTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(410, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 174);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Event";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(102, 105);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(228, 39);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Event Title";
            // 
            // deleteEventTextBox
            // 
            this.deleteEventTextBox.Location = new System.Drawing.Point(102, 54);
            this.deleteEventTextBox.Name = "deleteEventTextBox";
            this.deleteEventTextBox.Size = new System.Drawing.Size(228, 22);
            this.deleteEventTextBox.TabIndex = 0;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView titleDateDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createEventbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toModifyTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ViewEventButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox viewEventTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deleteEventTextBox;
    }
}