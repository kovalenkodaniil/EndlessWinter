using System;
using TMPro;
using UnityEngine;

namespace Core.Scripts.EventsLogic
{
    public class EventView : MonoBehaviour
    {
        [SerializeField] private JSONManager _jsonManager;
        [SerializeField] private TMP_Text _eventText;
        [SerializeField] private TMP_Text _locationText;

        public void Start()
        {
        }
    }
}