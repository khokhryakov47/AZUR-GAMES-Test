using UnityEngine;
using UnityEngine.Events;

public class PlayerWallet : MonoBehaviour
{
    private Character _character;
    private int _amount;

    public event UnityAction<int> AmountChanged;

    private void OnEnable()
    {
        _character.CoinCollected += OnCoinCollected;
    }

    private void OnDisable()
    {
        _character.CoinCollected -= OnCoinCollected;
    }

    public void Initialize(Character character)
    {
        _character = character;
    }

    private void OnCoinCollected(int coinPrice)
    {
        _amount += coinPrice;
        AmountChanged?.Invoke(_amount);
    }
}