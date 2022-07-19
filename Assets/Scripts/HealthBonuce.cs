using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pet_Proj
{
    public class HealthBonuce : MonoBehaviour
    {
        [SerializeField] private GameObject _healthObject;
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
                if (_healthObject.activeSelf == false)
                {
                    yield return new WaitForSeconds(_maxTime);
                    _healthObject.SetActive(true);

                }
                yield return new WaitForSeconds(_lifeTime);
                _healthObject.SetActive(false);
                yield return new WaitForSeconds(_maxTime);
                _healthObject.SetActive(true);
            }
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                other.gameObject.GetComponent<Hero>().CurrentHealth += _healthBonuce;
                _healthObject.SetActive(false);
            }
        }
    }
}
