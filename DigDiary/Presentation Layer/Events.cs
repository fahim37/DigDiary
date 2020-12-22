using DigDiary.Data_Access_Layer;
using DigDiary.Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigDiary.Presentation_Layer
{
    public partial class Events : Form
    {
        public TextBox ViewEventTextBox
        {
            get { return viewEventTextBox; }
        }

        public Events()
        {
            InitializeComponent();
            deleteButton.Click += this.RefreshGridView;
            deleteButton.Click += this.ClearFields;
        }

        private void Events_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            titleDateDataGridView.DataSource = eventService.GetTitleDatelist(MyGlobals.userId);
        }
        void RefreshGridView(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            titleDateDataGridView.DataSource = eventService.GetTitleDatelist(MyGlobals.userId);
        }
        void ClearFields(object sender, EventArgs e)
        {
            deleteEventTextBox.Text = toModifyTextBox.Text = viewEventTextBox.Text = string.Empty;
        }

        private void createEventbutton_Click(object sender, EventArgs e)
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
            this.Hide();
        }

        private void titleDateDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toModifyTextBox.Text = titleDateDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            viewEventTextBox.Text = titleDateDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            deleteEventTextBox.Text = titleDateDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void ViewEventButton_Click(object sender, EventArgs e)
        {
            EventDetails eventDetails = new EventDetails(this);
            eventDetails.Show();
            this.Hide();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            ModifyEvent modifyEvent = new ModifyEvent(this);
            modifyEvent.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.RemoveEvent(deleteEventTextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Category deleted successfully");
            }
            else
            {
                MessageBox.Show("Error in deleting category");
            }
        }
    }
}
