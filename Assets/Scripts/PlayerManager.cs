using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    #region Singleton

    public static PlayerManager instance;

    void Awake()
    {
        instance = this;    
    }

    #endregion

    public GameObject player;

    public void KillPlayer()
    {
        //death ui here

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

//redo comments into new script - e.g Respawn
