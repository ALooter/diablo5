using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable
{

    DialogTrigger dialogtrigger;

    void Start()
    {
        dialogtrigger = GetComponent<DialogTrigger>();
    }

    public override void Interact()
    {
        base.Interact();

        dialogtrigger.TriggerDialog();

    }
}
