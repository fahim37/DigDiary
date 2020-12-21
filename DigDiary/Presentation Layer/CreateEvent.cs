﻿using DigDiary.Logic_Layer;
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
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void CreateEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.CreateEvent(eventTitleTextBox.Text, descriptionTextBox.Text, dateTimePicker1.Text, moodComboBox.Text, importanceComboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Event Created successfully");
                Events events = new Events();
                events.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error in Creating Event");
            }

        }
    }
}
