using UnityEngine.SceneManagement;
using UnityEngine;
using System;

namespace Pet_Proj
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private Canvas _settingsCanvas;


        private void Awake()
        {
            _settingsCanvas.enabled = false;
        }
        private void Update()
        {
            if (_settingsCanvas.isActiveAndEnabled == true)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    _settingsCanvas.enabled = false;
                }
            }
        }
        public void StartGameBTN()
        {
            SceneManager.LoadScene("MainScene");
        }
        public void SettigsBtn()
        {
            _settingsCanvas.enabled = true;
        }
        

        
    }
}
