using Cinemachine;
using UnityEngine;


namespace Pet_Proj
{
    public class HeroSpawn : MonoBehaviour
    {
        [SerializeField] private GameObject _hero;
        [SerializeField] private Transform _spawn;
        [SerializeField] private CinemachineVirtualCamera _vcam;

        private void Awake()
        {
            heroSpawner();
        }
        private void heroSpawner()
        {
            var Hero = Instantiate(_hero, _spawn.position, Quaternion.identity);
            _vcam.LookAt = Hero.transform;
            _vcam.Follow = Hero.transform;
        }

    }
}