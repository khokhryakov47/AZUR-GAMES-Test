using System.Collections;
using UnityEngine;

public class CharacterTracker : MonoBehaviour
{ 
    [SerializeField] private float _smoothTime;
    [SerializeField] private Vector3 _offset;

    private Character _target;
    private Vector3 _velocity = Vector3.zero;
    private Coroutine _trackingJob;

    public void Initialize(Character terget)
    {
        _target = terget;

        if (_trackingJob != null)
            StopCoroutine(_trackingJob);

        StartCoroutine(Track());
    }

    private IEnumerator Track()
    {
        WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();

        while (_target != null)
        {
            Vector3 targetPosition = _target.transform.position + _offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, _smoothTime);
            yield return waitForFixedUpdate;
        }
    }
}