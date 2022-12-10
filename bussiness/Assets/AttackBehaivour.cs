using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaivour : StateMachineBehaviour
{
    Transform enemy;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.LookAt(enemy);

        float distance = Vector3.Distance(animator.transform.position, enemy.position);

        if (distance > 3)
        {
            animator.SetBool("IsAttacking", false);
        }
    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
