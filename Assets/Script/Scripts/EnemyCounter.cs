using Object_Pool;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EnemyCounters", menuName = "ScriptableObject/EnemyCouter", order = 0)]
public class EnemyCounter : ScriptableObject
{
    [SerializeField] private List<Couner> _couner;
    
    
    public void CountEnemy(ObjectPool objectPool)
    {
        for(int i =0;  i < _couner.Count; i++)
        {
            var obj = _couner[i];
            for(int j = 0; j <= obj.EnemyCount; j++)
            {
                objectPool.AddToPool(obj.EnemyType);
            }
        }
    }

}
