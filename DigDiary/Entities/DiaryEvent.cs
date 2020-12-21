using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigDiary.Entities
{
    class DiaryEvent
    {
        public string EventTitle { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public string ModificationDate { get; set; }
        public string Mood { get; set; }
        public string Importance { get; set; }
        public int UserId { get; set; }
    }
}
