using UnityEngine;


public class PlayerController : PlayerBase
{
    public float PlayerSpeed
    {
        get => _speed;
    }

    public Collider PlayerCollider
    {
        get => _colliderPl;
    }

    public Rigidbody PlayerRB 
    {
        get => _rigidbodyPl;
    }

    private Vector3 _movement;

    private void Awake()
    {
        _moveDirection = new Vector3();
    }

    private void Update()
    {
        _movement = _moveDirection;
        CalculateMovementInputSmoothing(_movement);
    }

    private void FixedUpdate()
    {
        PlayerMove(_movement);
    }
    
    
}
