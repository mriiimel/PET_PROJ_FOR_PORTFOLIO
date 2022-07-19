using UnityEngine;

public class Defence : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }

}
