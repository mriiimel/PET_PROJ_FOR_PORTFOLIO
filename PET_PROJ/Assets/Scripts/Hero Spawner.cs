using UnityEngine;



public class HeroSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _hero;
    void Start()
    {
        heroSpawner();
    }


    public void heroSpawner()
    {


        Instantiate(_hero, transform.position, Quaternion.identity);
    }
}

