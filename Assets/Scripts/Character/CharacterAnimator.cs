using UnityEngine;

[RequireComponent(typeof(Character))]
[RequireComponent(typeof(MouseInput))]
[RequireComponent(typeof(Animator))]
public class CharacterAnimator : MonoBehaviour
{ 
    private Animator _animator;
    private Character _character;
    private MouseInput _input;

    private const string RunParameter = "Run";
    private const string CelebrationParameter = "Celebration";

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _input = GetComponent<MouseInput>();
        _character = GetComponent<Character>();
    }

    private void OnEnable()
    {
        _character.Finished += OnFinished;
        _input.Running += OnRunning;
        _input.Stopped += OnStopped;
    }

    private void OnDisable()
    {
        _character.Finished -= OnFinished;
        _input.Running -= OnRunning;
        _input.Stopped -= OnStopped;
    }

    private void OnFinished() => Celebrate();

    private void OnRunning() => Run();

    private void OnStopped() => Stop();

    public void Celebrate() => _animator.SetBool(CelebrationParameter, true);

    public void Run() => _animator.SetBool(RunParameter, true);

    public void Stop() => _animator.SetBool(RunParameter, false);
}