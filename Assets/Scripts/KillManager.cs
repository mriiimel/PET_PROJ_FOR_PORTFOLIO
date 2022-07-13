using TMPro;
using UnityEngine;


namespace Pet_Proj
{
    
    public class KillManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private string _text;
        private float _enemiKilled;
        public float EnemiKilled
        {
            get { return _enemiKilled; }
            set { _enemiKilled = value; }
        }
       
        private void Update()
        {
            TotalKill(_enemiKilled);
        }
        private void TotalKill(float enemyKiled)
        {
            
            text.text = _text + enemyKiled.ToString();
        }
    }
}
