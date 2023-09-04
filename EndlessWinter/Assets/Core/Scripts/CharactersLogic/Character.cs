using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Core.Scripts.CharactersLogic
{
    public class Character : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private Image _icon;
        
        private CharacterData _data;

        public CharacterData Data => _data;

        public void Initialize(CharacterData data)
        {
            _data = data;

            _icon.sprite = _data.icon;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("Клик-клак");
        }
    }
}