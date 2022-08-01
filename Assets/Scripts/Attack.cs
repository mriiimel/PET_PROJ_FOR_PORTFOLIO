using UnityEngine;

namespace Pet_Proj
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] private Collider m_coll;
        private float _damage;

        public float Damage { get => _damage; private set => _damage = value; }

        private void Start()
        {
            var m_hero = FindObjectOfType<Hero>();
            _damage = m_hero.Damage;
        }
    }
}
