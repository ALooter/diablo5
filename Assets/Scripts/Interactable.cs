using UnityEngine;

public class Interactable : MonoBehaviour
{
    Transform player;

    public float radius;

    bool isfocused = false;

    bool hasinteracted = false;



    public virtual void Interact()
    {

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public void OnFocused(Transform playertransform)
    {
        isfocused = true;
        player = playertransform;
        hasinteracted = false;
    }

    public void OnDefocused()
    {
        isfocused = false;
        player = null;
        hasinteracted = false;
    }

    private void Update()
    {
        if (isfocused && !hasinteracted)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                Interact();
                hasinteracted = true;
            }
        }
    }
}
