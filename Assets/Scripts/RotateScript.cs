using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    private Transform _myTransform;
    [SerializeField] float _rotationVelocity = 300;

    private void Awake()
    {
        _myTransform = transform;
    }

    private void Update()
    {
        _myTransform.Rotate(Vector3.up, _rotationVelocity * Time.deltaTime);
    }
}
