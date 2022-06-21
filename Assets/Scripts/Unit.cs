using UnityEngine;


namespace Pet_Proj
{
    public abstract class Unit : MonoBehaviour
    {
        public float Health;
        public float Damage;
        public float Speed;
        public float RotationSpeed;
        
       
        public void GetDamage(float damage)
        {
            Health -= damage;
        }
    }

}