using UnityEngine;

[CreateAssetMenu(fileName = "HeroConfig", menuName = "ScriptableObject/HeroConfig", order = 0)]
public class HeroConfig : ScriptableObject
{
    [field: SerializeField] public float Health { get; set; }
    [field: SerializeField] public float Damage { get; set; }
    [field: SerializeField] public float Defence { get; set; }
    [field: SerializeField] public float Speed { get; set; }
}
