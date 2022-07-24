using UnityEngine;
using UnityEngine.AI;

namespace Pet_Proj
{
    public class AIpoints : MonoBehaviour
    {
        [SerializeField] Transform[] Points;
        public void AiPoints()
        {
            var m_enemy = GetComponent<Enemy>();
            var m_agent = m_enemy.GetComponent<NavMeshAgent>();
            if (!m_agent.pathPending)
            {
                var index = Random.Range(0, Points.Length);
                m_agent.destination = Points[index].position;
            }
        }
        private void Update()
        {
            AiPoints();
        }
    }
}
