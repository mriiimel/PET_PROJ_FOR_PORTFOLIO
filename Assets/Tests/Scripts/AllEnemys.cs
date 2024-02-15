using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyConfig", menuName = "ScriptableObject/EnemyConfig", order = 0)]
public class AllEnemys : ScriptableObject
{
  public List<EnemysConfig> EnemysConfigs;
}
