using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pet_Proj
{
    public class Enemy : Unit
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
           
        }
        float EnemyGetDamage(float Dameg)
        {
            float m_enemyHealth = Health;
            if (true) {
                m_enemyHealth -= Dameg;
                if (m_enemyHealth <= 0)
                {

                    gameObject.SetActive(false);
                }
            }
            return 0;
        }
    }
}
