using UnityEngine;
using UnityEngine.Events;

public class PlayerWallet : MonoBehaviour
{
    private Character _character;
    private int _amount;

    public event UnityAction<int> AmountChanged;

    public void Initialize(Character character)
    {
        _character = character;
        _character.CoinCollected += OnCoinCollected;
    }

    private void OnDestroy()
    {
        if (_character != null)
            _character.CoinCollected -= OnCoinCollected;
    }

    private void OnCoinCollected(int coinPrice)
    {
        _amount += coinPrice;
        AmountChanged?.Invoke(_amount);
    }
}