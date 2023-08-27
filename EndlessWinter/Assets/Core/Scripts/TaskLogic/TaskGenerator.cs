using UnityEngine;

namespace Core.Scripts.Managers
{
    public class TaskGenerator
    {
        private DataManager _dataManager;

        public TaskGenerator(DataManager dataManager)
        {
            _dataManager = dataManager;
            Debug.Log("Зарегистрировано");
        }
    }
}