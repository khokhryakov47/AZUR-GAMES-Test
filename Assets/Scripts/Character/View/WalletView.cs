using TMPro;
using UnityEngine;

[RequireComponent(typeof(SmoothTextChanger))]
public class WalletView : MonoBehaviour
{
    [SerializeField] private TMP_Text _view;
    [SerializeField] private PlayerWallet _wallet;

    private SmoothTextChanger _smoothChanger;

    private void OnEnable()
    {
        _wallet.AmountChanged += OnAmountChanged;
    }

    private void OnDisable()
    {
        _wallet.AmountChanged -= OnAmountChanged;
    }

    private void Awake()
    {
        _smoothChanger = GetComponent<SmoothTextChanger>();
        _smoothChanger.Initialize(_view);
    }

    private void OnAmountChanged(int amount)
    {
        _smoothChanger.StartSmoothChange(amount);
    }
}
