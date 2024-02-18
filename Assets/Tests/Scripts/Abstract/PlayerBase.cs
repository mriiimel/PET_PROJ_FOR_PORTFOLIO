using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class PlayerBase : MonoBehaviour, IPlayer
{
    [SerializeField] protected Rigidbody _rigidbodyPl;
    [SerializeField] protected Collider _colliderPl;
    [SerializeField] protected CinemachineVirtualCamera _vCam;
    [SerializeField] protected PlayerInput _playerInput;
    [SerializeField] protected float _speed;

    protected Vector3 _moveDirection;
    protected Vector3 _moveRotation;
    
    public void OnMove(InputAction.CallbackContext value)
    {
        _moveDirection = value.ReadValue<Vector2>();
        _rigidbodyPl.AddForce(new Vector3(_moveDirection.x, 0, _moveDirection.y) * _speed,ForceMode.VelocityChange);
    }
    public void PlayerMove(Vector3 move)
    {
        _rigidbodyPl.AddForce(move.x,0,move.y,ForceMode.VelocityChange);
    }
    
    public void CalculateMovementInputSmoothing(Vector3 movement)
    {
        
        _moveDirection = Vector3.Lerp(movement, _moveDirection, Time.deltaTime * _speed);

    }

    public void PlayerRotate(InputAction.CallbackContext value) 
    {
        _moveRotation = value.ReadValue<Vector2>();
        Quaternion rotate = Quaternion.Euler(0,_moveRotation.x, 0);
        _rigidbodyPl.MoveRotation(rotate);
    }
    protected void CameraRotate()
    {
       
    }

   
}
