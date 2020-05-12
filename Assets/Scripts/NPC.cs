using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable
{

    DialogTrigger dialogtrigger;
    QuestGiver questgiver;

    void Start()
    {
        dialogtrigger = GetComponent<DialogTrigger>();
        questgiver = GetComponent<QuestGiver>();
    }

    public override void Interact()
    {
        base.Interact();

        dialogtrigger.TriggerDialog();
        questgiver.QuestPrompt();
    }
}
