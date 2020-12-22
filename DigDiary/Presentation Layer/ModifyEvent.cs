﻿using DigDiary.Entities;
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
    public partial class ModifyEvent : Form
    {
        string eveTitle;
        public ModifyEvent(Events ev)
        {
            InitializeComponent();
            eveTitle = ev.ViewEventTextBox.Text;
        }
        private void ModifyEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ModifyEvent_Load(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            DiaryEvent diaryEvent = new DiaryEvent();
            diaryEvent = eventService.GetEventDetailss(eveTitle);
            modifyTitleTextBox.Text = diaryEvent.EventTitle;
            modifyDescriptionTextBox.Text = diaryEvent.Description;
            modifyMoodComboBox.Text = diaryEvent.Mood;
            modifyImportanceComboBox.Text = diaryEvent.Importance;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (modifyTitleTextBox.Text == "")
            {
                MessageBox.Show("Event title can not be empty");
            }
            else if (modifyDescriptionTextBox.Text == "")
            {
                MessageBox.Show("Description is empty");
            }
            else if (modifyMoodComboBox.Text == "")
            {
                MessageBox.Show("Mood is not selected");
            }
            else if (modifyImportanceComboBox.Text == "")
            {
                MessageBox.Show("Importance is not selected");
            }
            else
            {
                EventService eventService = new EventService();
                int result = eventService.ModifyEventDetails(modifyTitleTextBox.Text, modifyDescriptionTextBox.Text, modifyDateTimePicker.Text, modifyMoodComboBox.Text, modifyImportanceComboBox.Text, eveTitle);
                if (result > 0)
                {
                    MessageBox.Show("Event Modified successfully");
                    Events events = new Events();
                    events.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error in Modifying Event");
                }
            }
            
        }
    }
}
