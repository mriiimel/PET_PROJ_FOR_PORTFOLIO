using UnityEngine;

public interface IPlayer
    {
    public float PlayerHP { get; set; }
    public float PlayerMP { get; set; }
    public float PlayerSpeed { get; set; }
    public Vector3 MoveDirection { get; set ; }
    public Vector3 MoveRotation { get; set; }
    public Quaternion RotationPl { get; set; }

    public void PlayerMove(Vector3 move);
}
