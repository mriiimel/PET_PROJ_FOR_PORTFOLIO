using UnityEngine;

[CreateAssetMenu(fileName = "FaceCh", menuName = "ScriptableObject/FaceChange", order = 1)]
public class FaceChange : ScriptableObject
{
    public Texture Idleface, WalkFace, jumpFace, attackFace, damageFace;
}
