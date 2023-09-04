using Core.Scripts.CharactersLogic;
using Core.Scripts.LocationLogic;
using Core.Scripts.Managers;
using UnityEngine;
using Zenject;

namespace Core.Scripts.Infrastructure
{
    public class GameplaySceneInstaller : MonoInstaller
    {
        [SerializeField] private Canvas _parentCanvas;
        [SerializeField] private GameObject _jsonManager;
        [SerializeField] private PrefabContainer _prefabContainer;
        [SerializeField] private TaskView _taskView;
        [SerializeField] private MapView _mapView;
        
        public override void InstallBindings()
        {
            var jsonManager = Container.InstantiatePrefabForComponent<JSONManager>(_jsonManager);
            Container.Bind<JSONManager>().FromInstance(jsonManager).AsSingle();
            
            var prefabContainer = Container.InstantiatePrefabForComponent<PrefabContainer>(_prefabContainer);
            Container.Bind<PrefabContainer>().FromInstance(prefabContainer).AsSingle();
            
            Container.Bind<DataManager>().AsSingle();
            Container.Bind<TaskGenerator>().AsSingle();
            Container.Bind<CharacterFactory>().AsSingle();
            
            var taskView = Container.InstantiatePrefabForComponent<TaskView>(_taskView, _parentCanvas.transform);
            Container.Bind<TaskView>().FromInstance(taskView).AsSingle();
            
            var mapView = Container.InstantiatePrefabForComponent<MapView>(_mapView, _parentCanvas.transform);
            Container.Bind<MapView>().FromInstance(mapView).AsSingle();
        }
    }
}