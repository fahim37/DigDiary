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
        }

        private void ViewEventButton_Click(object sender, EventArgs e)
        {
            EventDetails eventDetails = new EventDetails(this);
            eventDetails.Show();
        }
    }
}
