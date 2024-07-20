using Cinemachine;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Collider _collider;
    [SerializeField] private CinemachineVirtualCamera _vCamera;

    private IPlayer _playerBase;

    private Vector3 _movement;
    private Quaternion _rotation;

    public Rigidbody Rigidbody { get => _rigidbody; set => _rigidbody = value; }
    public Collider Collider { get => _collider; set => _collider = value; }
    public CinemachineVirtualCamera VCamera { get => _vCamera; set => _vCamera = value; }

    private void Update()
    {
        _movement = _playerBase.MoveDirection;
    }

    private void FixedUpdate()
    {
        _playerBase.PlayerMove(_movement);
        
    }
    
    
}
