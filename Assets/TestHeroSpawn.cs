using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
namespace TEST_SCRIPT
{
    public class TestHeroSpawn : MonoBehaviour
    {
        [SerializeField] private GameObject _heroGobj;
        [SerializeField] private Transform _heroSpawnPos;
        [SerializeField] private CinemachineVirtualCamera _vcam;
        private void Start()
        {
            HeroSpawn();
        }
        private void HeroSpawn()
        {
            var heroSpawn = Instantiate(_heroGobj, _heroSpawnPos.position, Quaternion.identity);
            _vcam.LookAt = heroSpawn.transform;
            _vcam.Follow = heroSpawn.transform;
        }

    }
}
