using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{
    public event UnityAction<int> CoinCollected;
    public event UnityAction Finished;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Coin collectedCoin))
        {
            int coinPrice = collectedCoin.Collect();
            CoinCollected?.Invoke(coinPrice);
        }
        if(other.TryGetComponent(out Finish finish))
        {
            Finished?.Invoke();
        }
    }
}