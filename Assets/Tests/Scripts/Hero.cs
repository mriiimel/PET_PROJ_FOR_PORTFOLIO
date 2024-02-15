using System;
using Cinemachine;
using UnityEngine;


public class Hero : MonoBehaviour,IUnit
{
    [SerializeField] private HeroConfig _heroConfig;
    private float _heroMaxHealth;
    private float _heroDamage;
    private float _heroMaxSpeed;
    private float _defence;
    public Rigidbody heroRigidbody;
    

    private PlayerController _playerController;
    

    private void Start()
    {
        _heroMaxHealth = _heroConfig.Health;
        _heroDamage = _heroConfig.Damage;
        _heroMaxSpeed = _heroConfig.Speed;
        _defence = _heroConfig.Defence;
        _playerController = new PlayerController(heroRigidbody,_heroMaxSpeed);
    }

    private void Update()
    {
        _playerController.Move();
    }
    
    
}

