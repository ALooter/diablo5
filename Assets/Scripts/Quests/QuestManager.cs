using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{

    #region Singleton

    public static QuestManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject questbox;
    
    public Text title;
    public Text description;
    public Image reward1;

    public Text test_questlogui;
    private Queue<string> test_activequests;

    private Quest currentquest;

    void Start()
    {
        test_activequests = new Queue<string>();
    }

    public void PromptQuest(Quest quest)
    {
        questbox.SetActive(true);
        title.text = quest.title;
        description.text = quest.description;
        reward1.sprite = quest.reward1.icon;
        currentquest = quest;
    }

    public void DeclineQuest()
    {
        questbox.SetActive(false);
    }

    public void AcceptQuest()
    {
        questbox.SetActive(false);
        currentquest.isactive = true;

        //replace string with Quest object and you get nice code (i hope)
        test_activequests.Enqueue(currentquest.title);
        //foreach (string que in test_activequests)
        //{
            test_questlogui.text +=" -!- " + currentquest.title + "\n";
        //}
    }


}
