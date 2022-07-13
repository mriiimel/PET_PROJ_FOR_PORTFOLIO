using UnityEngine.AI;
using UnityEngine;
using System.Collections;

namespace Pet_Proj
{

    public class Enemy : Unit
    {
        [SerializeField] private NavMeshAgent _navMesh;
        [SerializeField] private GameObject m_EnemyObj;
        private GameObject _target;
        public GameObject Target
        {
            get => _target;

            set => _target = value;
        }



        private void Update()
        {
            EnemyLook();
        }
        private void EnemyLook()
        {
            Vector3 toTarget = Target.transform.position - transform.position;

            Vector3 toTargetXZ = new Vector3(toTarget.x, 0f, toTarget.z);

            transform.rotation = Quaternion.LookRotation(toTargetXZ);
        }
        private void OnTriggerEnter(Collider other)
        {
            var heroObj = FindObjectOfType<Hero>();
            if (other.gameObject.CompareTag("Weapon"))
            {
                var damage = heroObj.GetComponent<Hero>().Damage;
                TakeDamage(damage);
            }
            
        }
        public void TakeDamage(float damage)
        {
            Health -= damage;
            var killMG = FindObjectOfType<KillManager>();
            if (Health <= 0)
            {
                m_EnemyObj.SetActive(false);
                killMG.EnemiKilled++;
                if (m_EnemyObj.activeSelf == false)
                {
                    StartCoroutine(ReloadEnemy());
                }
            }
        }
        IEnumerator ReloadEnemy()
        {
            yield return new WaitForSeconds(5);
            m_EnemyObj.SetActive(true);
        }
    }
}
