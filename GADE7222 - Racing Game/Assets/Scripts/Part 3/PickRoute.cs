using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickRoute : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Random.Range(0, 2) == 0)
        {
            animator.SetBool("Shortcut", true);
        }
        else
        {
            animator.SetBool("Shortcut", false);
        }

    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("Shortcut", false);
    }
}
