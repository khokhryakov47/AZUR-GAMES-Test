using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CharacterInput))]
public abstract class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    protected CharacterInput Input;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        Input = GetComponent<CharacterInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        Vector3 offset = direction.normalized;
        _rigidbody.MovePosition(_rigidbody.position + offset * _speed * Time.deltaTime);
    }
}