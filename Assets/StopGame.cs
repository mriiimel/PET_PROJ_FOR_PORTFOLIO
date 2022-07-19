using UnityEngine.SceneManagement;
using UnityEngine;

namespace Pet_Proj {
    public class StopGame : MonoBehaviour
    {
        [SerializeField] private GameObject _killMG;
        
        void Update()
        {
            var totalKill = _killMG.GetComponent<KillManager>().EnemiKilled;
            if (totalKill == 3)
            {
                EndLVL();
            }
        }

        private void EndLVL()
        {
            SceneManager.LoadScene("SecondScene");
        }
    }
}
