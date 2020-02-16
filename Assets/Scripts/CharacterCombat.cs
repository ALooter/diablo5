using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{

    CharacterStats thisstats;

    private float attackcooldown = 0f;
    public float damagedelay = 0.5f;

    public event System.Action OnAttack;

    void Start()
    {
        thisstats = GetComponent<CharacterStats>();
    }

    void Update()
    {
        attackcooldown -= Time.deltaTime;
    }

    public void Attack(CharacterStats targetstats)
    {
        if (attackcooldown <= 0f)
        {
            StartCoroutine(DoDamage(targetstats, damagedelay));

            if (OnAttack != null)
            {
                OnAttack();
            }

            attackcooldown = 1f / thisstats.attackspeed.GetValue();
        }
        
    }

    IEnumerator DoDamage (CharacterStats targetstats, float damagedelay)
    {
        yield return new WaitForSeconds(damagedelay);

        targetstats.TakeDamage(thisstats.damage.GetValue());
    }

}
