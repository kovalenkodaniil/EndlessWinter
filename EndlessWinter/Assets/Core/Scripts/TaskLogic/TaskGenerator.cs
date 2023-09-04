using Core.Scripts.Infrastructure;
using UnityEngine;

namespace Core.Scripts.Managers
{
    public class TaskGenerator
    {
        private DataManager _dataManager;
        private PrefabContainer _prefabContainer;
        private Transform _parentWindow;

        public TaskGenerator(DataManager dataManager, PrefabContainer prefabContainer)
        {
            _dataManager = dataManager;
            _prefabContainer = prefabContainer;
        }

        public void GenerateTask()
        {
            var _parentWindow = Object.Instantiate(_prefabContainer.TaskWindow).transform;

            TaskData data = _dataManager.TaskData[Random.Range(0, _dataManager.TaskData.Count)];
            
            Object.Instantiate(_prefabContainer.TaskPrefab, _parentWindow).Initialize(data);
        }
    }
}