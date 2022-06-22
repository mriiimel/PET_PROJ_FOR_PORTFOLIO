using UnityEngine;


namespace Pet_Proj
{
    public class Hero : Unit
    {
        [SerializeField] private Rigidbody _rigidbody;


        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            Damage = 100;
            Health = 100;
        }


        private void FixedUpdate()
        {
            HeroMove();
            HeroRotate();
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
            float mouseInput = Input.GetAxis("Mouse X");
            Vector3 vector = new Vector3(0f, mouseInput * RotationSpeed, 0f);
            Quaternion deltaRotation = Quaternion.Euler(vector);
            _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);
        }
        
    }
}
