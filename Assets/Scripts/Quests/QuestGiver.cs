using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{

    public Quest quest;

    QuestManager questmanager;



    public void QuestPrompt()
    {
        questmanager = QuestManager.instance;
        questmanager.PromptQuest(quest);
    }

    public void QuestAccept()
    {
        questmanager.AcceptQuest(quest);
    }

    public void QuestDecline()
    {
        questmanager.DeclineQuest();
    }
}
