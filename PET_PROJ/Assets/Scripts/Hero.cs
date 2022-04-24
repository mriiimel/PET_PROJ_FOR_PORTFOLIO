using UnityEngine;
namespace Pet_Proj
{
    public class Hero : Unit
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private GameObject _hero;
        

        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            
        }

        
        void Update()
        {
            HeroMove();
        }
        void HeroMove()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            _rigidbody.velocity = new Vector3(horizontal, 0, vertical)*Speed*Time.deltaTime;
            
        }
        float HeroDoDamage(float HeroDamage)
        {

            return 1;
        }


    }
}
