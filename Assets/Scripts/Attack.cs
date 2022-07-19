
using UnityEngine;

public class Attack : MonoBehaviour
{
    
    void Start()
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }

    
}
