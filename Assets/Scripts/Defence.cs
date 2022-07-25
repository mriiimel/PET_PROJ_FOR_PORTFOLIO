using UnityEngine;

public class Defence : MonoBehaviour
{
    [SerializeField] private Collider m_DefColl;

    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            m_DefColl.enabled = true;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            m_DefColl.enabled = false;
        }
    }

}
