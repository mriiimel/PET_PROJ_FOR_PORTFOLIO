using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pet_Proj
{
    public class Hero : Unit
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Animator _animator;
        public float CurrentHealth { get; set; }


        private void Start()
        {
            CurrentHealth = Health;
        }


        private void FixedUpdate()
        {
            HeroMove();
            HeroRotate();
            CurrentHP();
        }
        private void HeroMove()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 moveVector = transform.TransformDirection(horizontal, 0, vertical);
            _rigidbody.velocity = new Vector3(moveVector.x * Speed, _rigidbody.velocity.y, moveVector.z * Speed);
            
        }
        private void HeroRotate()
        {
            float mouseInputX = Input.GetAxis("Mouse X");
            Vector3 vectorX = new(0f, mouseInputX * RotationSpeed, 0f);
            Quaternion deltaRotation = Quaternion.Euler(vectorX);
            _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);
        }
       
        private void OnTriggerEnter(Collider other)
        {
            
            var m_enemyObj = FindObjectOfType<Enemy>();
            if (other.gameObject.CompareTag("Enemy"))
            {
                var enemyDMG = m_enemyObj.GetComponent<Enemy>().Damage;
                TakeDamage(enemyDMG);
            }
        }
        private void TakeDamage(float damage)
        {
            CurrentHealth -= damage;
            Debug.Log(CurrentHealth);
            if (CurrentHealth <= 0)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        private void CurrentHP()
        {
            if(CurrentHealth > Health) CurrentHealth = Health;
        }
    }
}
