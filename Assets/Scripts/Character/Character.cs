using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{
    public event UnityAction<int> CoinCollected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Coin collectedCoin))
        {
            int coinPrice = collectedCoin.Collect();
            CoinCollected?.Invoke(coinPrice);
        }
    }
}