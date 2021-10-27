using UnityEngine;

public class CharacterTracker : MonoBehaviour
{
    [SerializeField] private Character _target;
    [SerializeField] private float _smoothTime;
    [SerializeField] private Vector3 _offset;

    private Vector3 _velocity = Vector3.zero;

    private void FixedUpdate()
    {
        Vector3 targetPosition = _target.transform.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, _smoothTime);
    }
}
