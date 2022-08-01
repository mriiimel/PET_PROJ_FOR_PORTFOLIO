using UnityEngine.AI;
using UnityEngine;


namespace Pet_Proj
{

    public class Enemy : Unit
    {
        [SerializeField] private NavMeshAgent _navMesh;
        [Space(10)]
        [SerializeField] private float _distToAttak;

        private GameObject _target;

        public GameObject Target
        {
            get => _target;

            set => _target = value;
        }
        private float m_currentHealth;

        private void Awake()
        {
            m_currentHealth = Health;
        }
        private void Update()
        {
            EnemyLook();
        }
        private void EnemyLook()
        {
            var disToHero = Vector3.Distance(gameObject.transform.position, Target.transform.position);
            if (disToHero < _distToAttak)
            {
                Vector3 toTarget = Target.transform.position - transform.position;

                Vector3 toTargetXZ = new Vector3(toTarget.x, 0f, toTarget.z);

                transform.rotation = Quaternion.LookRotation(toTargetXZ * RotationSpeed * Time.deltaTime);

                AttackToHero(disToHero);
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            
            if (other.gameObject.CompareTag("Sword"))
            {
                var damage = FindObjectOfType<Attack>().Damage;
                TakeDamage(damage);
            }
        }

        private void TakeDamage(float damage)
        {
            m_currentHealth -= damage;
            
            var killMG = FindObjectOfType<KillManager>();
            if (m_currentHealth <= 0)
            {
                gameObject.SetActive(false);

                killMG.EnemiKilled++;
            }
        }


        private void AttackToHero(float DisToAttak)
        {
            if (DisToAttak < _distToAttak)
            {
                _navMesh.SetDestination(Target.transform.position);

                if (Vector3.Distance(gameObject.transform.position, Target.transform.position) == _navMesh.stoppingDistance)
                {
                    _navMesh.isStopped = true;
                }
            }
        }

    }
}
