using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSCR : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float Speed;

   
    private void FixedUpdate()
    {
        HeroMove();
        MoveCamera();
    }
    private void HeroMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveVector = transform.TransformDirection(horizontal, 0, vertical);
        _rigidbody.velocity = new Vector3(moveVector.x * Speed, _rigidbody.velocity.y, moveVector.z * Speed);
    }
    private void MoveCamera()
    {
        float rotationSpeed = 5f;
        float mouseInputY = Input.GetAxis("Mouse Y");
        _camera.transform.position = _rigidbody.transform.position;
        _camera.transform.rotation = _rigidbody.transform.rotation;
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Vector3 vector = new(transform.rotation.x, mouseInputY * rotationSpeed, transform.rotation.z);
            Quaternion quaternion = Quaternion.Euler(vector);
            _rigidbody.transform.rotation *= quaternion; 
        }
    }
}
