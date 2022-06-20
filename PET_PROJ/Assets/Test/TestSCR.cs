using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSCR : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float Speed;

    void Start()
    {

    }
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
        _camera.transform.position = _rigidbody.transform.position;
        if (Input.GetKey(KeyCode.Mouse1))
        {
            float mouseInputX = Input.GetAxis("Mouse Y");
            float mouseInputY = Input.GetAxis("Mouse X");

            Vector3 vector = new(-mouseInputX, mouseInputY, transform.rotation.z);
            Quaternion quaternion = Quaternion.Euler(vector);
            _camera.transform.rotation = quaternion;
        }
    }
}
