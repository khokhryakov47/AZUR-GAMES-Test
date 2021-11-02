using UnityEngine;

public class CharacterForwardMovement : CharacterMovement
{
    private void FixedUpdate()
    {
        if (Input.Run)
            Move(Vector3.forward);
    }
}