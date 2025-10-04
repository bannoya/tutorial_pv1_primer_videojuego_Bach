using System;
using UnityEngine;

public class SmoothMovementStrategy : IMovementStrategy
{
    public void Move(Transform transform, Player player, float direction)
    {
        float MoveInX = direction * player.Velocity * Time.deltaTime;
        transform.Translate(MoveInX,0,0);
    }

}
