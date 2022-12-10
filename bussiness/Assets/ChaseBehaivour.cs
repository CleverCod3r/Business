using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class ChaseBehaivour : StateMachineBehaviour
{
    NavMeshAgent agent;
    Transform enemy;

    float attackRange = 2;
    float chaseRange = 10;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.GetComponent<NavMeshAgent>();
        agent.speed = 4;

        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(enemy.position);
        float distance = Vector3.Distance(animator.transform.position, enemy.position);

        if (distance < attackRange)
        {
            animator.SetBool("IsAttacking", true);
        }

        if (distance > 10)
        {
            animator.SetBool("IsChasing", false);
        }
    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(enemy.transform.position);
        agent.speed = 2;
    }

}
