using Core.Scripts.Managers;
using TMPro;
using UnityEngine;

public class Task : MonoBehaviour
{
    [SerializeField] private TMP_Text _title;
    [SerializeField] private TMP_Text _description;
    
    public void Initialize(TaskData  data)
    {
        _title.text = data.Name;
        _description.text = data.Description;
    }
}
