using System.Collections;
using UnityEngine;

public static class SmoothUI
{
    public static IEnumerator Show(float duration, CanvasGroup panel)
    {
        yield return ChangeAlphaValue(1, duration, panel);
        panel.blocksRaycasts = true;
        panel.interactable = true;
    }

    public static IEnumerator Hide(float duration, CanvasGroup panel)
    {
        yield return ChangeAlphaValue(0, duration, panel);
        panel.blocksRaycasts = false;
        panel.interactable = false;
    }

    private static IEnumerator ChangeAlphaValue(float targetValue, float duration, CanvasGroup panel)
    {
        float elapsed = 0;
        float startValue = panel.alpha;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            panel.alpha = Mathf.Lerp(startValue, targetValue, elapsed / duration);
            yield return null;
        }
    }
}