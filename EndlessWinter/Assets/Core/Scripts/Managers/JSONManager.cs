using System;
using System.Collections.Generic;
using Core.Scripts.Managers;
using UnityEngine;

public class JSONManager : MonoBehaviour
{
    [SerializeField] private TextAsset _jsonEvent;
    [SerializeField] private TextAsset _jsonTask;

    public void LoadEvent(DataManager manager)
    {
        var tempEvents = JsonUtility.FromJson<SchemeEvents>(_jsonEvent.text);
        
        manager.AddEvent(tempEvents);
    }
    
    public void LoadTask(DataManager manager)
    {
        var tempTasks = JsonUtility.FromJson<SchemeEvents>(_jsonTask.text);
        
        manager.AddTask(tempTasks);
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

[Serializable]
public sealed class ShemeTasks
{
    public List<ShemeTask> Tasks;
}

[Serializable]
public sealed class ShemeTask
{
    public string Name;
    public string Description;
}
