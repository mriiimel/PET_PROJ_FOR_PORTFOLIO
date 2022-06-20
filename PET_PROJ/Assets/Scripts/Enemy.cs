using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pet_Proj
{

    public class Enemy : Unit
    {
        [SerializeField] private Transform _target;
        

        private void Update()
        {
            EnemyLook();
        }
        private void EnemyLook()
        {
            //Vector3 toTarget = _target.position - transform.position;
            //Vector3 toTargetXZ = new Vector3(toTarget.x, 0f, toTarget.z);
            //transform.rotation = Quaternion.LookRotation(toTargetXZ);
            transform.LookAt(_target);
        }
    }
}
