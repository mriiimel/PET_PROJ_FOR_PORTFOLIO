using UnityEngine;


public class PlayerController : IAttackable,IMovable,IGetDamage
{
    private Rigidbody _heroRigidbody;
    private Vector3 _moveVector = Vector3.zero;
    private float _speed;


    public PlayerController(Rigidbody heroRigidbody, float speed)
    {
        _heroRigidbody = heroRigidbody;
        _speed = speed;
    }
    
    public void Attack()
    {
        
    }

    
    public void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        _moveVector = new Vector3(horizontal,0,vertical);
        _heroRigidbody.velocity = new Vector3(_moveVector.x*_speed,_heroRigidbody.velocity.y,_moveVector.z*_speed);
    }

    public void GetDamage()
    {
        
    }
    
    
}
