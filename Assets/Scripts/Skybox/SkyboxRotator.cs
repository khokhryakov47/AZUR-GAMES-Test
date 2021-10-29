using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    [SerializeField] private float _rotationPerSecond;

    private void Start()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * _rotationPerSecond);
    }
}
