using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{

    public GameObject loot;

    public override void Die()
    {
        base.Die();

        //add ragdoll effect / death animation

        //drop loot

        Vector3 position = transform.position;
            
        //foreach (GameObject item in items)
        //{
          
            // Add code here to change the position slightly
            // so the items are scattered a little bit.
            Instantiate(loot, position, Quaternion.identity);
         
         //  }
            

        //Enemy death
        Destroy(gameObject);
        
    }
}
