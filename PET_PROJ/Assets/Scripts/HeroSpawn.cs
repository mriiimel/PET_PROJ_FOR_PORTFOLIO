using Cinemachine;
using UnityEngine;

public class HeroSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _hero;
    [SerializeField] private CinemachineVirtualCamera _vcam;
    void Start()
    {
        heroSpawner();
       
    }


    public void heroSpawner()
    {
        var Hero = Instantiate(_hero, transform.position, Quaternion.identity);
        
        _vcam.LookAt = Hero.transform;
        _vcam.Follow = Hero.transform;
    }
    
}
