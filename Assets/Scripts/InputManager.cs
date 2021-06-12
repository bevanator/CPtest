using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    private float distance = 1f;
    [SerializeField]
    private CharacterMove character;



    private void Update()
    {
        GetInput();
    }


    private void SendMoveCommand(Transform objectToMove, Vector3 direction, float distance)
    {
        ICommands movement = new Move(objectToMove, direction, distance);
        character?.AddCommand(movement as Move);
    }


    private void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.W)) SendMoveCommand(character.transform, Vector3.forward, distance);

        if (Input.GetKeyDown(KeyCode.A)) SendMoveCommand(character.transform, Vector3.left, distance);
        if (Input.GetKeyDown(KeyCode.S)) SendMoveCommand(character.transform, Vector3.back, distance);
        if (Input.GetKeyDown(KeyCode.D)) SendMoveCommand(character.transform, Vector3.right, distance);
        if (Input.GetKeyDown(KeyCode.Z)) character?.UndoCommand();
        if (Input.GetKeyDown(KeyCode.R)) character?.RedoCommand();
    }
        
        




}
