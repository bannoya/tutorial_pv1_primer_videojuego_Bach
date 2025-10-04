using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private List<ICommand> commands;

    void Start()
    {
        playerMovement = gameObject.GetComponent<PlayerMovement>();
        commands = new List<ICommand>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");



        commands.Clear();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            commands.Add(new AccelerateMoveCommand(playerMovement, horizontalInput));
        }
        if (Input.GetKey(KeyCode.Space))
        {
            commands.Add(new MoveCommand(playerMovement, horizontalInput));
        }


        foreach (var cmd in commands)
            cmd.Execute();
    }

}
