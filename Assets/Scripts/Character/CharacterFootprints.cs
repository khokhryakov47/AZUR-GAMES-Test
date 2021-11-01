using UnityEngine;

public class CharacterFootprints : MonoBehaviour
{
    [SerializeField] private ParticleSystem _leftFoot;
    [SerializeField] private ParticleSystem _rightFoot;

    public void SpawnLeft()
    {
        Spawn(_leftFoot);
    }

    public void SpawnRight()
    {
        Spawn(_rightFoot);
    }

    private void Spawn(ParticleSystem foot)
    {
        foot.Play();
    }
}