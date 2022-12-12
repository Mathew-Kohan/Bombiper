using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed;
    private float _verticalInput;

    [SerializeField]
    private bool _isRotate = false;

    void Update()
    {
        if(Input.GetAxis("Vertical") != 0)
        {
            _verticalInput = Input.GetAxis("Vertical");
            _isRotate = true;  
        }
        if (_isRotate)
            transform.Rotate(Vector3.left, _verticalInput * _rotationSpeed * Time.deltaTime);
    }

    public void RotateUp(bool b)
    {
        _verticalInput = 1;
        _isRotate = b;
    }
    public void RotateDown(bool b)
    {
        _verticalInput = -1;
        _isRotate = b;
    }
}
