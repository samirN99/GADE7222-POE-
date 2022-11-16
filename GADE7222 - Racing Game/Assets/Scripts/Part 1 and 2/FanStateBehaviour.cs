using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FanStatePattern.Animation
{
    public class FanStateBehaviour : StateMachineBehaviour
    {
        float animationChangeTime = float.PositiveInfinity;
        float animationChangeRate = 4f;
        private float currentAnimation;
        private float endAnimation;

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animationChangeTime += Time.deltaTime;
            if(animationChangeTime >= animationChangeRate)
            {
                currentAnimation = animator.GetFloat("Actions");
                endAnimation = Random.Range(0f, 1f);
                animationChangeTime = 0f;
            }

            animator.SetFloat("Actions", Mathf.Lerp(currentAnimation, endAnimation, animationChangeTime / animationChangeRate));

            base.OnStateUpdate(animator, stateInfo, layerIndex);
        }
    }

}
