using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 1.0f;
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private float _rotationSpeed = 1.0f;
    [SerializeField] private GameObject _turret;
    private float _horizontalInput;
    private float _verticalInput;
    private float _mouseX;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        _mouseX = Input.GetAxis("Mouse X");
        if (_verticalInput != 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * _speed * _verticalInput);
        }
        if (_horizontalInput != 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * _rotationSpeed * _horizontalInput);
        }
        if (_mouseX != 0)
        {
            _turret.transform.Rotate(Vector3.up * Time.deltaTime * _sensitivity * _mouseX);
        }
    }
}
