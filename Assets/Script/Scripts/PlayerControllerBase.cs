using Cinemachine;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.AI;
using UnityEngine.InputSystem;
using Zenject;

public class PlayerControllerBase:MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Collider _collider;
    [SerializeField] private Camera _vCamera;
    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotation;
    [SerializeField] private PlayerInput _playerInput;

   
    

    private Vector3 _moveDirection;
    private Vector3 _moveRotation;
    private Quaternion _rotationPl;

    public Vector3 MoveDirection { get => _moveDirection; set => _moveDirection = value; }
    public Vector3 MoveRotation { get => _moveRotation; set => _moveRotation = value; }
    public Quaternion RotationPl { get => _rotationPl; set => _rotationPl = value; }
    

    public void OnMove(InputAction.CallbackContext value)
    {
        _moveDirection = value.ReadValue<Vector2>();

        _rigidbody.AddForce(new Vector3(_moveDirection.x,0, _moveDirection.y) * _speed,ForceMode.VelocityChange);
        
    }
    public void PlayerMove(Vector3 move)
    {
        _rigidbody.AddForce(new Vector3(move.x *_speed, 0,move.y * _speed), ForceMode.VelocityChange);
    }
    public void Look(InputAction.CallbackContext value)
    {
        var obj = value.ReadValue<Vector2>();
        _rotationPl = Quaternion.Euler(0, obj.x * _speedRotation, 0);
        _rigidbody.MoveRotation(_rigidbody.rotation * _rotationPl.normalized);
    }
    public void LookRotation(Quaternion rotate)
    {
        _rigidbody.MoveRotation(_rigidbody.rotation * rotate.normalized);
    }
    


}
