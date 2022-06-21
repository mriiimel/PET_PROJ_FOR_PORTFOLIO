using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pet_Proj
{
    public class HealthBonuce : MonoBehaviour
    {
        [SerializeField] private GameObject _healthObj;
        [SerializeField] private float _maxTime;
        [SerializeField] private float _lifeTime;
        [SerializeField] private float _healthBonuce;
        void Start()
        {
            StartCoroutine(HealthSpawnCD());
        }
        private IEnumerator HealthSpawnCD()
        {
            while (true)
            {
                yield return new WaitForSeconds(_lifeTime);
                _healthObj.SetActive(false);
                StartCoroutine(LifeTime());
            }
        }
        private IEnumerator LifeTime()
        {
            yield return new WaitForSeconds(_maxTime);
            _healthObj.SetActive(true);
        }
        private void OnTriggerEnter(Collider other)
        {
            if(other == FindObjectOfType<Hero>())
            {
                var heroHP = GetComponent<Hero>();
                heroHP.Health += _healthBonuce;
            }
        }
    }
}
