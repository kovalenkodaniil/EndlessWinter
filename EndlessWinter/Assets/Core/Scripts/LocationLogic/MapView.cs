using System.Collections.Generic;
using Core.Scripts.CharactersLogic;
using Core.Scripts.Infrastructure;
using Core.Scripts.Managers;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace Core.Scripts.LocationLogic
{
    public class MapView : MonoBehaviour, IDragHandler, IBeginDragHandler
    {
        [SerializeField] private List<Location> _locations;
        private Vector2 _previoslyDragPosition;
        private RectTransform _rectTransform;
        private PrefabContainer _prefabContainer;
        private CharacterFactory _characterFactory;
        private Canvas _parentCanvas;
        private TaskView _taskView;

        [Inject]
        public void Initialize(PrefabContainer prefabContainer, CharacterFactory characterFactory, TaskView taskView)
        {
            _rectTransform = GetComponent<RectTransform>();
            _parentCanvas = GetComponentInParent<Canvas>();
            
            transform.SetSiblingIndex(0);
            
            _characterFactory = characterFactory;
            _prefabContainer = prefabContainer;
            _taskView = taskView;
            
            _characterFactory.ShowCharactersPanel(_parentCanvas.transform);
            
            _locations.ForEach(location =>
            {
                location.Initialize(this);
            });
        }

        public void OnDrag(PointerEventData eventData)
        {
            _rectTransform.anchoredPosition += (eventData.position - _previoslyDragPosition);
            _previoslyDragPosition = eventData.position;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            _previoslyDragPosition = eventData.position;
        }

        public void ShowTaskForLocation(Location currentLocation)
        {
            _taskView.ShowTaskScreen();
        }
    }
}