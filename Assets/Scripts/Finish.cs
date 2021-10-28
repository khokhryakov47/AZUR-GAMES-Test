using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] _finishEffects;

    public event UnityAction CharacterFinished;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Character character))
        {
            CharacterFinished?.Invoke();

            ActivateEffects();
        }
    }

    private void ActivateEffects()
    {
        foreach (var effect in _finishEffects)
        {
            effect.Play();
        }
    }
}