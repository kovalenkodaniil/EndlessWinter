using Core.Scripts.Infrastructure;
using TMPro;
using UnityEngine;
using Zenject;

namespace Core.Scripts.Managers
{
    public class TaskView : MonoBehaviour
    {
        [SerializeField] private GameObject _taskScreen;
        [SerializeField] private TMP_Text _title;
        [SerializeField] private TMP_Text _description;
        private TaskGenerator _taskGenerator;
        private PrefabContainer _prefabContainer;

        [Inject]
        public void Initialize(PrefabContainer prefabContainer, TaskGenerator taskGenerator)
        {
            _prefabContainer = prefabContainer;
        }

        public void ShowTaskScreen()
        {
            _taskScreen.SetActive(true);
        }
    }
}