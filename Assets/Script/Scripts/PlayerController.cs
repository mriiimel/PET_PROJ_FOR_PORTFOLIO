using UnityEngine;
using Zenject;

public class PlayerController : PlayerControllerBase
{

    private Vector3 _movement;
    private Quaternion _rotation;
    [Inject]private PlayerControllerBase _playerBase;



   

    private void Update()
    {
        _rotation = _playerBase.RotationPl;
        _movement = _playerBase.MoveDirection;
    }

    private void FixedUpdate()
    {
        _playerBase.PlayerMove(_movement);
        _playerBase.LookRotation(_rotation);
        
    }
    
    
}
