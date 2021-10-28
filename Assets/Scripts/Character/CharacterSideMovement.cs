using UnityEngine;

public class CharacterSideMovement : CharacterMovement
{
    [SerializeField] private float _minLimit;
    [SerializeField] private float _maxLimit;

    private void Update()
    {
        float clampedPositionX = Mathf.Clamp(transform.position.x, _minLimit, _maxLimit);
        transform.position = new Vector3(clampedPositionX, transform.position.y, transform.position.z);
    }

    private void FixedUpdate()
    {
        if (Input.RunButtonPressed)
        {
            Move(new Vector3(Input.DeltaX, 0, 0));
        }
    }
}
