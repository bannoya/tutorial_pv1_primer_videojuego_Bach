using System;
using UnityEngine;
using UnityEngine.Rendering;

public class AccelerateMovementStrategy : IMovementStrategy
{
    private float currentSpeed = 0f;
    private float acceleration = 500f;
    public void Move(Transform transform, Player player, float direction)
    {
        currentSpeed += direction * acceleration * Time.deltaTime;
        currentSpeed = Mathf.Clamp(currentSpeed, -player.Acceleration, player.Acceleration); 
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
    }

}