using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class FinishPanel : MonoBehaviour
{
    [SerializeField] private Finish _finish;
    [SerializeField] private float _changeDuration;
    [SerializeField] private Button _nextLevelButton;

    private CanvasGroup _canvasGroup;

    public event UnityAction ButtonClicked;

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    private void OnEnable()
    {
        ButtonClicked += OnButtonClicked;
        _nextLevelButton.onClick.AddListener(ButtonClicked);
        _finish.CharacterFinished += OnCharacterFinished;
    }

    private void OnDisable()
    {
        ButtonClicked -= OnButtonClicked;
        _nextLevelButton.onClick.RemoveListener(ButtonClicked);
        _finish.CharacterFinished -= OnCharacterFinished;
    }

    private void OnCharacterFinished()
    {
        Open();
    }

    private void OnButtonClicked()
    {
        Close();
    }

    private void Open()
    {
        StartCoroutine(SmoothUI.Show(_changeDuration, _canvasGroup));
    }

    private void Close()
    {
        StartCoroutine(SmoothUI.Hide(_changeDuration, _canvasGroup));
    }
}