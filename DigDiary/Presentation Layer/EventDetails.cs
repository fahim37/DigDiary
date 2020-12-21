using DigDiary.Entities;
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
    public partial class EventDetails : Form
    {
        string evTitle;
        public EventDetails(Events ev)
        {
            InitializeComponent();
            evTitle = ev.ViewEventTextBox.Text;
            //label1.Text = ev.ViewEventTextBox.Text;
        }

        private void EventDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EventDetails_Load(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            DiaryEvent diaryEvent = new DiaryEvent();
            diaryEvent = eventService.GetEventDetailss(evTitle);
            label1.Text = diaryEvent.EventTitle;
            detailsDescriptionTextBox.Text = diaryEvent.Description;

        }
    }
}
