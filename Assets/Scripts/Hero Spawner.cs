using UnityEngine;


namespace Pet_Proj
{
    public class HeroSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _hero;
        

        void Start()
        {
            heroSpawner();
        }


        public void heroSpawner()
        {
            var Hero = Instantiate(_hero, transform.position, Quaternion.identity);
        }
    }
}

