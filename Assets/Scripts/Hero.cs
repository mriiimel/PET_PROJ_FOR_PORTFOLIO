using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pet_Proj
{
    public class Hero : Unit
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Animator _animator;
        public float CurrentHealth { get; set; }
        #region Animation
        private string m_CurrentState;

        private bool _isAttaked;
        private bool _isWalkbl;

        private const string IDILE_BATTLE = "Idle_Battle";
        private const string ATTACK_ONE = "Attack01";
        private const string ATTACK_TWO = "Attack02";
        private const string WALK_FORWARD = "WalkForwardBattle";
        private const string RUN_FORWARD = "RunForwardBattle";
        private const string DEFEND = "Defend";
        private const string GET_HIT = "GetHit";

        #endregion

        private void Start()
        {
            CurrentHealth = Health;
            Cursor.visible = false;
        }

        private void FixedUpdate()
        {
            HeroMove();
            HeroRotate();
            CurrentHP();
        }

        #region Hero Move Methods


        private void HeroMove()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 moveVector = transform.TransformDirection(horizontal, 0, vertical);
            _rigidbody.velocity = new Vector3(moveVector.x * Speed, _rigidbody.velocity.y, moveVector.z * Speed);

            if (horizontal != 0 || vertical != 0)
            {
                AnimHero(WALK_FORWARD);
                //_isWalkbl = true;
            }
            else
            {
                AnimHero(IDILE_BATTLE);
                //_isWalkbl = false;
            }
            //Посмотреть работу со слоями анимации для параллельной работы анимации 
            //if (Input.GetKeyDown(KeyCode.Mouse0) & !_isWalkbl)
            //{
            //    AnimHero(ATTACK_ONE);
            //}
            //else
            //    AnimHero(IDILE_BATTLE);
        }
        private void HeroRotate()
        {
            float mouseInputX = Input.GetAxis("Mouse X");
            Vector3 vectorX = new(0f, mouseInputX * RotationSpeed, 0f);
            Quaternion deltaRotation = Quaternion.Euler(vectorX);
            _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);
        }
        #endregion

        #region Collision event and Take Damage 
        private void OnTriggerEnter(Collider other)
        {

            var m_enemyObj = FindObjectOfType<Enemy>();
            if (other.gameObject.CompareTag("EnemyKys"))
            {
                var enemyDMG = m_enemyObj.GetComponent<Enemy>().Damage;
                TakeDamage(enemyDMG);
            }
        }
        private void TakeDamage(float damage)
        {
            CurrentHealth -= damage;

            if (CurrentHealth <= 0)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        private void CurrentHP()
        {
            if (CurrentHealth > Health) CurrentHealth = Health;
        }
        #endregion

        private void AnimHero(string m_newAnimation)
        {
            if (m_CurrentState == m_newAnimation) return;
            _animator.Play(m_newAnimation);
            m_CurrentState = m_newAnimation;
        }
        
    }
}
