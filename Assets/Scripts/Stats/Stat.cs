using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat
{
    [SerializeField]
    private int basevalue = 1;

    private List<int> modifiers = new List<int>();

    public int GetValue()
    {
        int finalvalue = basevalue;
        modifiers.ForEach(x => finalvalue += x);
        return finalvalue;
    }

    public void AddModifier(int modifier)
    {
        if (modifier != 0)
        {
            modifiers.Add(modifier);
        }
    }

    public void RemoveModifier(int modifier)
    {
        if (modifier != 0)
        {
            modifiers.Remove(modifier);
        }
    }

}
