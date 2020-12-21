﻿using DigDiary.Data_Access_Layer;
using DigDiary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigDiary.Logic_Layer
{
    class EventService
    {
        EventDataAccess eventDataAccess;
        public EventService()
        {
            this.eventDataAccess = new EventDataAccess();
        }
        public List<TitleDate> GetTitleDatelist(int id)
        {
            return this.eventDataAccess.GetTitleDate(Convert.ToInt32(id));
        }
        public int CreateEvent(string eventTitle, string description, string creationDate, string mood, string importance)
        {
            DiaryEvent diaryEvent = new DiaryEvent()
            {
                EventTitle = eventTitle,
                Description = description,
                CreationDate = creationDate,
                ModificationDate = creationDate,
                Mood = mood,
                Importance = importance,
                UserId = MyGlobals.userId
            };
            eventDataAccess = new EventDataAccess();
            return eventDataAccess.CreateEvent(diaryEvent);
        }
    }
}