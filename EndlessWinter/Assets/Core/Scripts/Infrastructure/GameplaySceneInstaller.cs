using Core.Scripts.Managers;
using UnityEngine;
using Zenject;

namespace Core.Scripts.Infrastructure
{
    public class GameplaySceneInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _jsonManager;
        public override void InstallBindings()
        {
            var jsonManager = Container.InstantiatePrefabForComponent<JSONManager>(_jsonManager);
            
            Container.Bind<JSONManager>().FromInstance(jsonManager).AsSingle();
            Container.Bind<DataManager>().AsSingle();
            Container.Bind<TaskGenerator>().AsSingle().NonLazy();
        }
    }
}