using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable
{

    PlayerManager playermanager;
    CharacterStats thisstats;

    void Start()
    {
        playermanager = PlayerManager.instance;
        thisstats = GetComponent<CharacterStats>();
    }

    public override void Interact()
    {
        base.Interact();

        CharacterCombat playercombat = playermanager.player.GetComponent<CharacterCombat>();

        if (playercombat != null)
        {
            playercombat.Attack(thisstats);
        }
    }
}
