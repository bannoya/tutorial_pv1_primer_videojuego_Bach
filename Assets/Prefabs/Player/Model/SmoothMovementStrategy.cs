using System;
using UnityEngine;

public class SmoothMovementStrategy : IMovementStrategy
{
    public void Move(Transform transform, Player player)
    {
        float MoveInX = Input.GetAxis("Horizontal") * player.Velocity * Time.deltaTime;
        transform.Translate(MoveInX,0,0);
    }

}
