using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWaypoint : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.gameObject.GetComponent<AdvancedAI>().target = GameObject.FindObjectOfType<CheckpointManager>()
            .GetCheckPoints(animator.GetInteger("currentCheckpoint") + 1, animator.GetBool("Shortcut"));
        //Debug.Log(animator.GetInteger("currentCheckpoint"));
        if(animator.GetInteger("currentCheckpoint") == 6)
        {
            animator.SetInteger("currentCheckpoint", 0);
        }
    }
}
