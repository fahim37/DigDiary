using DigDiary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigDiary.Data_Access_Layer
{
    class EventDataAccess
    {
        DataAccess dataAccess;
        public EventDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public DiaryEvent GetEventDetails(string eventTitle)
        {
            string sql = "SELECT * FROM DIARYEVENTS WHERE EventTitle='" + eventTitle + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            
            reader.Read();
            DiaryEvent diaryEvent = new DiaryEvent();
            diaryEvent.EventTitle = reader["EventTitle"].ToString();
            diaryEvent.Description = reader["Description"].ToString();
            diaryEvent.CreationDate = reader["CreationDate"].ToString();
            diaryEvent.ModificationDate = reader["ModificationDate"].ToString();
            diaryEvent.Mood = reader["Mood"].ToString();
            diaryEvent.Importance = reader["Importance"].ToString();
            diaryEvent.UserId = (int)reader["UserId"];
            return diaryEvent;
        }
        public List<TitleDate> GetTitleDate(int id)
        {
            string sql = "SELECT * FROM DIARYEVENTS WHERE UserId=" + id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<TitleDate> titleDates = new List<TitleDate>();
            while (reader.Read())
            {
                TitleDate titleDate = new TitleDate();
                titleDate.EventTitle = reader["EventTitle"].ToString();
                titleDate.CreationDate = reader["CreationDate"].ToString();
                titleDates.Add(titleDate);
            }
            return titleDates;
        }
        public int CreateEvent(DiaryEvent diaryEvent)
        {
            string sql = "INSERT INTO DIARYEVENTS (EventTitle,Description,CreationDate,ModificationDate,Mood,Importance,UserId) VALUES('" + diaryEvent.EventTitle + "','" + diaryEvent.Description + "','" + diaryEvent.CreationDate + "','" + diaryEvent.ModificationDate + "','" + diaryEvent.Mood + "','" + diaryEvent.Importance + "'," + diaryEvent.UserId + ")";
            return this.dataAccess.ExecuteQuery(sql);
        }
        public int UpdateEvent(DiaryEvent diaryEvent,string eveTitle)
        {
            string sql = "UPDATE DiaryEvents SET EventTitle='" + diaryEvent.EventTitle + "',Description='" + diaryEvent.Description + "',ModificationDate='" + diaryEvent.ModificationDate + "',Mood='"+ diaryEvent.Mood +"',Importance='"+ diaryEvent.Importance +"' WHERE EventTitle= '"+ eveTitle+"'";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int DeleteEvent(string eventTitle)
        {
            string sql = "DELETE FROM DiaryEvents WHERE EventTitle= '" + eventTitle + "'";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
}
