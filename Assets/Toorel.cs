using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace TEST_SCRIPT
{
    public class Toorel : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        private void Start()
        {
            var vectorTarget = _target.GetComponent<Vector3>();
            var vectorGameObj = GetComponent<Vector3>();
        }

        /*private void Update()
        {
            if (Vector3.Distance(, _target.position))
            {
                
            }
            
        }*/

        private void LookAt()
        {
            gameObject.transform.LookAt(_target);
        }
    }
}
