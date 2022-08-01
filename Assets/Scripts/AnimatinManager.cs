using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pet_Proj
{
    public class AnimatinManager : MonoBehaviour
    {
        [SerializeField] GameObject m_hero;
        private Animator _heroAnimator;

        private const string IDEL_BATLE = "Idle_Battle";
        private const string ATTACK_ONE = "Attack01";
        private const string ATTACK_TWO = "Attack02";
        private const string DIE = "Die";
        private const string GET_HIT = "GetHit";
        private const string DEFEND = "Defend";
    }
}
