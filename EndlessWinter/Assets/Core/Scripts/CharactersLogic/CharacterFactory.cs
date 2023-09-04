using Core.Scripts.Infrastructure;
using Core.Scripts.Managers;
using UnityEngine;

namespace Core.Scripts.CharactersLogic
{
    public class CharacterFactory
    {
        private DataManager _dataManager;
        private PrefabContainer _prefabContainer;
        private Transform _charactersPanel;

        public CharacterFactory(DataManager dataManager, PrefabContainer prefabContainer)
        {
            _dataManager = dataManager;
            _prefabContainer = prefabContainer;
        }

        public void ShowCharactersPanel(Transform parentTransform)
        {
            if (_charactersPanel == null)
                _charactersPanel = Object.Instantiate(_prefabContainer.CharactersPanel, parentTransform).transform;
            else
                _charactersPanel.gameObject.SetActive(true);
        }

        public void CreateCharacter(CharacterData data)
        {
            Object.Instantiate(_prefabContainer.CharacterPrefab, _charactersPanel).Initialize(data);
        }
    }
}