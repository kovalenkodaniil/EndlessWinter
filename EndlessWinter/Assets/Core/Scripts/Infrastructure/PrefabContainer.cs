using Core.Scripts.CharactersLogic;
using UnityEngine;

namespace Core.Scripts.Infrastructure
{
    public class PrefabContainer: MonoBehaviour
    {
        [field: SerializeField] public Task TaskPrefab { get; private set; }
        [field: SerializeField] public GameObject TaskWindow { get; private set; }
        [field: SerializeField] public GameObject CharactersPanel { get; private set; }
        [field: SerializeField] public Character CharacterPrefab { get; private set; }
    }
}