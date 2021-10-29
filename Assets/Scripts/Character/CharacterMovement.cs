using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(MouseInput))]
public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    protected MouseInput Input;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        Input = GetComponent<MouseInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        Vector3 offset = direction.normalized;
        _rigidbody.MovePosition(_rigidbody.position + offset * _speed * Time.deltaTime);
    }
}