using UnityEngine;
using UnityEngine.Events;

public abstract class CharacterInput : MonoBehaviour
{
    public abstract bool Run { get; }
    public abstract float DeltaX { get; }

    public abstract event UnityAction Running;
    public abstract event UnityAction Stopped;
}