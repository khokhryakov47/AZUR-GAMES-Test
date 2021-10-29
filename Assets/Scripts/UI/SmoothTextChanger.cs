using System.Collections;
using UnityEngine;
using TMPro;

public class SmoothTextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Coroutine _smoothChangeJob;
    private float _previousValue = 0;
    private TMP_Text _view;

    public void Initialize(TMP_Text view)
    {
        _view = view;
    }

    public void StartSmoothChange(int amount)
    {
        if (_view == null)
            throw new System.Exception("View is not set");

        if (_smoothChangeJob != null)
            StopCoroutine(_smoothChangeJob);

        _smoothChangeJob = StartCoroutine(SmoothChange(amount, _duration));
    }

    private IEnumerator SmoothChange(int targetValue, float duration)
    {
        float elapsed = 0;
        float nextValue = 0;
        float startValue = _previousValue;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            nextValue = Mathf.Lerp(startValue, targetValue, elapsed / duration);
            SetTextValue(nextValue);
            _previousValue = nextValue;
            yield return null;
        }
    }

    private void SetTextValue(float value)
    {
        value = (int)value;
        _view.text = value.ToString();
    }
}