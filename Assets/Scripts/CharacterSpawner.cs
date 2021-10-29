using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Character _template;
    [SerializeField] private CharacterTracker _tracker;
    [SerializeField] private PlayerWallet _wallet;

    private void Awake()
    {
        Character character = Spawn();
        _tracker.Initialize(character);
        _wallet.Initialize(character);
    }

    private Character Spawn()
    {
        return Instantiate(_template, _spawnPoint.position, Quaternion.identity);
    }
}