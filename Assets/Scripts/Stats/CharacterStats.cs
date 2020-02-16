using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public int maxhealth = 100;
    public int currenthealth { get; private set; }

    public Stat damage;
    public Stat armor;
    public Stat attackspeed;

    void Awake()
    {
        currenthealth = maxhealth;
    }

    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        currenthealth -= damage;
        Debug.Log(transform.name + " took" + damage + " damage.");
        if (currenthealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        //die in some way
        Debug.Log(transform.name + " died.");
    }


}
