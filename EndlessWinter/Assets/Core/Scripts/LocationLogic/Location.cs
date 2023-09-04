using UnityEngine;
using UnityEngine.EventSystems;

namespace Core.Scripts.LocationLogic
{
    public class Location : MonoBehaviour, IPointerClickHandler
    {
        private MapView _mapView;
        
        public void Initialize(MapView mapView)
        {
            _mapView = mapView;
            Debug.Log("Регистрация локации");
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            _mapView.ShowTaskForLocation(this);
            
            Debug.Log("Клик");
        }
    }
}