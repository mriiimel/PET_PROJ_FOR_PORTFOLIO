using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    
    public void StartGameBTN()
    {
        SceneManager.LoadScene("MainScene");
    }

    
}
