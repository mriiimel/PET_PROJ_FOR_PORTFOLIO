using UnityEngine;


namespace Pet_Proj
{
    public class Hero : Unit
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Animator _animator;
       
        private float _currentHealth;
        public float CurrentHealth
        {
            get => _currentHealth; 
            set => _currentHealth = value;
        }

        private void Start()
        {
            _currentHealth = Health;
            //Attack();
        }


        private void FixedUpdate()
        {
            HeroMove();
            HeroRotate();
            Attack();
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
        private void Attack()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                _animator.Play("Attack01");
            }
            
        }
    }
}
