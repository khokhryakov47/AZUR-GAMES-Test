using UnityEngine;
using UnityEngine.Events;

public class MouseInput : CharacterInput
{
    [SerializeField] private KeyCode _runButton = KeyCode.Mouse0;

    private float _deltaX;
    private float _positionX;

    public override bool Run => Input.GetKey(_runButton);
    public override float DeltaX => _deltaX;

    public override event UnityAction Running;
    public override event UnityAction Stopped;

    private void Update()
    {
        if (Input.GetKeyDown(_runButton))
        {
            _positionX = Input.mousePosition.x;
            Running?.Invoke();
        }
        else if (Input.GetKey(_runButton))
        {
            _deltaX = Input.mousePosition.x - _positionX;
            _positionX = Input.mousePosition.x;
        }
        else if (Input.GetKeyUp(_runButton))
        {
            _deltaX = 0;
            Stopped?.Invoke();
        }
    }
}