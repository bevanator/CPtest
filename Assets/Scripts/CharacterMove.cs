using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private List<Move> commandlist = new List<Move>();
    private int index;
    public void AddCommand(Move command)
    {
        commandlist.Add(command as Move);
        command.Execute();
        index++;
    }

    public void UndoCommand()
    {
        if (commandlist.Count == 0) return;

        if (index>0)
        {
            commandlist[index - 1].Undo();
            index--;
        }

    }

    public void RedoCommand()
    {
        if (commandlist.Count == 0) return;
        if (index < commandlist.Count)
        {
            index++;
            commandlist[index-1].Execute(); 
        }

    }

}
