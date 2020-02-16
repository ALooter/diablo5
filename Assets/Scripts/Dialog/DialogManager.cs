using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    #region Singleton

    public static DialogManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject dialogbox;

    public Text speakernametext;
    public Text dialogtext;
    public Image dialogface;

    //---transfer to dialog script
    float sentencedelay = 3f;

    private Queue<string> sentences;


    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog (Dialog dialog)
    {
        speakernametext.text = dialog.speakername;
        dialogface.sprite = dialog.dialogface;

        dialogbox.SetActive(true);

        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            //no more sentences
            EndDialog();
            return;
        }

        //there are sentences left 
        string sentence = sentences.Dequeue();
        dialogtext.text = sentence;
        StartCoroutine(NextSentence(sentencedelay));
    }

    public void EndDialog()
    {
        StopAllCoroutines();
        dialogbox.SetActive(false);
    }

    IEnumerator NextSentence(float sentencedelay)
    {
        yield return new WaitForSeconds(sentencedelay);

        DisplayNextSentence();
    }

}
