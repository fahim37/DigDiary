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
        public ModifyEvent()
        {
            InitializeComponent();
        }
        private void ModifyEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ModifyEvent_Load(object sender, EventArgs e)
        {

        }

        
    }
}
