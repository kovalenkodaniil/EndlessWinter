using System;
using System.Collections;
using System.Collections.Generic;
using Core.Scripts.Managers;
using UnityEngine;

public class JSONManager : MonoBehaviour
{
    [SerializeField] private TextAsset _jsonEvent;

    public void LoadEvent(DataManager manager)
    {
        var tempEvents = JsonUtility.FromJson<SchemeEvents>(_jsonEvent.text);
        
        manager.AddEvent(tempEvents);
    }
}

[Serializable]
public sealed class SchemeEvents
{
    public List<SchemeEvent> Events;
}

[Serializable]
public sealed class SchemeEvent
{
    public string Name;
    public string Description;
    public string Answer;
}
