using System;
using UnityEngine;
using UnityEngine.Rendering;

public class AccelerateMovementStrategy : IMovementStrategy
{
    private float currentSpeed = 0f;
    private float acceleration = 2f;
    public void Move(Transform transform, Player player)
    {
        currentSpeed += Input.GetAxis("Horizontal") * acceleration * Time.deltaTime;
        currentSpeed = Mathf.Clamp(currentSpeed, -player.Acceleration, player.Acceleration); 
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
    }

}