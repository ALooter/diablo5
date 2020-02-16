using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{

    public bool isactive;

    public string title;
    public string description;

    public Item reward1;
    public int goldreward;
    public int xpreward;
}
