using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    DialogManager dialogmanager;

    public void TriggerDialog()
    {
        dialogmanager = DialogManager.instance;
        dialogmanager.StartDialog(dialog);
    }
}
