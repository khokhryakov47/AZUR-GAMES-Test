using UnityEngine;

public class MouseInput : MonoBehaviour
{
    [SerializeField] private KeyCode _runButton = KeyCode.Mouse0;

    private float _deltaX;
    private float _positionX;

    public bool RunButtonPressed => Input.GetKey(_runButton);
    public float DeltaX => _deltaX;

    private void Update()
    {
        if (Input.GetKeyDown(_runButton))
        {
            _positionX = Input.mousePosition.x;
        }
        else if (Input.GetKey(_runButton))
        {
            _deltaX = Input.mousePosition.x - _positionX;
            _positionX = Input.mousePosition.x;
        }
        else if (Input.GetKeyUp(_runButton))
        {
            _deltaX = 0;
        }
    }
}