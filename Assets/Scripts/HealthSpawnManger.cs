using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pet_Proj
{
    public class HealthSpawnManger : MonoBehaviour
    {
        [SerializeField] private GameObject m_healthObject;
        [SerializeField] private Transform m_healthSpawnPosition;
        

        private void Start()
        {
            HealthManager();
        }
        private void HealthManager()
        {
            Instantiate(m_healthObject, m_healthSpawnPosition.position, Quaternion.identity);
        }
    }
}
