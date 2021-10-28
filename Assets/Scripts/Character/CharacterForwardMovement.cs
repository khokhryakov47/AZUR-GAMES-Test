using UnityEngine;

public class CharacterForwardMovement : CharacterMovement
{
    private void FixedUpdate()
    {
        if (Input.RunButtonPressed)
            Move(Vector3.forward);
    }
}