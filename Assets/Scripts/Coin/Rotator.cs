using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private int _degreesInSeconds;

    private void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, _degreesInSeconds * Time.deltaTime);
    }
}