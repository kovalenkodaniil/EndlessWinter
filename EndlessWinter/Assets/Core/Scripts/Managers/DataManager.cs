using System.Collections.Generic;
using Core.Scripts.EventsLogic;
using UnityEngine;
using Zenject;

namespace Core.Scripts.Managers
{
    public class DataManager
    {
        public List<EventData> EventsData { get; private set; }
        public List<TaskData> TaskData { get; private set; }

        public DataManager(JSONManager jsonManager)
        {
            TaskData = new List<TaskData>();
            EventsData = new List<EventData>();
            
            jsonManager.LoadEvent(this);
            jsonManager.LoadTask(this);
        }

        public void AddEvent(SchemeEvents events)
        {
            events.Events.ForEach(x =>
            {
                var tempEvent = new EventData();
                tempEvent.Name = x.Name;
                tempEvent.Description = x.Description;
                
                EventsData.Add(tempEvent);
            });
        }
        
        public void AddTask(SchemeEvents tasks)
        {
            tasks.Events.ForEach(x =>
            {
                var tempEvent = new TaskData();
                tempEvent.Name = x.Name;
                tempEvent.Description = x.Description;
                
                TaskData.Add(tempEvent);
            });
        }
    }
}