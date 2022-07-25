using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private Collider m_coll;
    
    void Update()
    {
        
        
        if(Input.GetMouseButtonDown(0))
        {
            m_coll.enabled = true;
        }else if (Input.GetMouseButtonDown(1))
        {
            m_coll.enabled = false;
        }
    }

    
}
