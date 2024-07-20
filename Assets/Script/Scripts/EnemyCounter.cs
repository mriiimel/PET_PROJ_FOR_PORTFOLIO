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
}
