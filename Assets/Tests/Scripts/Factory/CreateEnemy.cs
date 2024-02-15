using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Pet_Proj;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreateEnemy: MonoBehaviour
{
    [SerializeField] private AllEnemys _allEnemys;
    [SerializeField] private List<Transform> _enemySpawns;
    [SerializeField] private int _maxEnemyCount;
    [SerializeField] private int _maxTinyEnemy;
    [SerializeField] private int _maxHeavyEnemy;
    [SerializeField] private int _maxHealthEnemy;
    [SerializeField] private int _maxBerserkEnemy;
    [SerializeField] private int _maxMageEnemy;
    [SerializeField] private int _maxBigEnemy;
    [SerializeField] private int _maxAssassinEnemy;
    [SerializeField] private int _maxBossEnemy;
    
    public int CurrentEnemyCount { get; set; }
    private Transform EnemySpawns;
    

    public void InstEnemy(EnemyTypes enemyTypes)
    {
        var TransformEnemySpawn = EnemySpawn();
        var enemyConfig = _allEnemys.EnemysConfigs.First((x) => x.enemyTypes == enemyTypes);
        Enemy enemy = Instantiate(enemyConfig.Enemys, TransformEnemySpawn.position , Quaternion.identity);
    }

    private Transform EnemySpawn()
    {
        
        foreach (var collection in _enemySpawns)
        {
            EnemySpawns = collection;
        }

        return EnemySpawns;
    }
}