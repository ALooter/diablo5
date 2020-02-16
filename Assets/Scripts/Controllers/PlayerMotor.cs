using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour
{
    Transform target; //target to follow
    NavMeshAgent agent; //reference to navmeshagent of player

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
            FaceTarget();
        }
    }

    public void MoveToPoint (Vector3 point)
    {
        agent.SetDestination(point);
    }

    public void FollowTarget(Interactable newtarget)
    {
        agent.stoppingDistance = newtarget.radius * 0.8f;
        agent.updateRotation = false;

        target = newtarget.transform;
    }

    public void StopFollowingTarget()
    {
        agent.stoppingDistance = 0f;
        agent.updateRotation = true;

        target = null;
    }

    void FaceTarget()
    {
        Vector3 lookontarget = (target.position - transform.position).normalized;
        Quaternion lookrotation = Quaternion.LookRotation(new Vector3(lookontarget.x, 0f, lookontarget.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookrotation, Time.deltaTime * 5f);
    }
}
