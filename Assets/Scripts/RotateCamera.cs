using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed;


    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.left, verticalInput * _rotationSpeed * Time.deltaTime);
    }
}
