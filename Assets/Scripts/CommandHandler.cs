using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Move> commandlist = new List<Move>();

    public void AddCommand(Move command)
    {
        commandlist.Add(command as Move);
        command.Execute();
    }

    public void UndoCommand()
    {
        if (commandlist.Count == 0) return;
        else
        {
            commandlist[commandlist.Count - 1].Undo();
            commandlist.RemoveAt(commandlist.Count - 1);
        }
    }
}
