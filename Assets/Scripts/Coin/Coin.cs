using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _cost;
    [SerializeField] private ParticleSystem _destroyEffect;

    public int Collect()
    {
        Instantiate(_destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        return _cost;
    }
}
