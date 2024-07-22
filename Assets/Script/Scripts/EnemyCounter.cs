using Object_Pool;
using UnityEngine;


[CreateAssetMenu(fileName = "EnemyCounters", menuName = "ScriptableObject/EnemyCouter", order = 0)]
public class EnemyCounter : ScriptableObject
{
    [SerializeField] private int _maxTinySlimes;
    [SerializeField] private int _maxKingSlimes;
    [SerializeField] private int _maxWarriorSlimes;
    [SerializeField] private int _maxRabbitSlimes;
    [SerializeField] private int _maxVikingSlimes;
    [SerializeField] private int _maxBigSlimes;
    [SerializeField] private int _maxBigLeafSlimes;
    [SerializeField] private int _maxBigSproutSlimes;
    [SerializeField] private int _maxBigKingSlimes;
    public int MaxTinySlimes { get => _maxTinySlimes; private set => _maxTinySlimes = value; }
    public int MaxKingSlimes { get => _maxKingSlimes; private set => _maxKingSlimes = value; }
    public int MaxWarriorSlimes { get => _maxWarriorSlimes; private set => _maxWarriorSlimes = value; }
    public int MaxRabbitSlimes { get => _maxRabbitSlimes; private set => _maxRabbitSlimes = value; }
    public int MaxVikingSlimes { get => _maxVikingSlimes; private set => _maxVikingSlimes = value; }
    public int MaxBigSlimes { get => _maxBigSlimes; private set => _maxBigSlimes = value; }
    public int MaxBigLeafSlimes { get => _maxBigLeafSlimes; private set => _maxBigLeafSlimes = value; }
    public int MaxBigSproutSlimes { get => _maxBigSproutSlimes; private set => _maxBigSproutSlimes = value; }
    public int MaxBigKingSlimes { get => _maxBigKingSlimes; private set => _maxBigKingSlimes = value; }

    
}
