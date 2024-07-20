using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

public class PlayerBase : IPlayer
{

    [Inject]private PlayerController _playerController;
    private Rigidbody _rigidbodyPl;
    private Collider _colliderPl;
    private CinemachineVirtualCamera _vCam;
    private float _speed;
    private float _rotateSpeed;
    private float _playerHP;
    private float _playerMP;

    private Vector3 _moveDirection;
    private Vector3 _moveRotation;
    private Quaternion _rotationPl;

    public Vector3 MoveDirection { get => _moveDirection; set => _moveDirection = value; }
    public Vector3 MoveRotation { get => _moveRotation; set => _moveRotation = value; }
    public Quaternion RotationPl { get => _rotationPl; set => _rotationPl = value; }
    public float PlayerHP { get => _playerHP; set => _playerHP = value; }
    public float PlayerMP { get => _playerMP; set => _playerMP = value; }
    public float PlayerSpeed { get => _speed; set => _speed = value; }

    private void Init()
    {
        _rigidbodyPl = _playerController.Rigidbody;
        _colliderPl = _playerController.Collider;
        _vCam = _playerController.VCamera;
    }

    public void OnMove(InputAction.CallbackContext value)
    {
        _moveDirection = value.ReadValue<Vector2>();
        
        _rigidbodyPl.AddForce(new Vector3(_moveDirection.x,0, _moveDirection.y) * _speed,ForceMode.VelocityChange);
        
    }
    public void PlayerMove(Vector3 move)
    {
        _rigidbodyPl.AddForce(move.x,0,move.y,ForceMode.VelocityChange);
    }




}
