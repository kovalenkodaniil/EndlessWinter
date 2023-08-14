using System.Collections.Generic;
using Core.Scripts.EventsLogic;
using UnityEngine;

namespace Core.Scripts.Managers
{
    public class DataManager: MonoBehaviour
    {
        [SerializeField] private JSONManager _jsonManager;
        [field: SerializeField] private List<EventData> EventsData { get; set; }

        private void Start()
        {
            _jsonManager.LoadEvent(this);
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
    }
}