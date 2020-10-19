﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMarchineBehaviour : StateMachineBehaviour
{
    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        
    }

    // OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (animator.gameObject.GetComponent<StateManager>().MyEnumPLayMode == StateManager.EnumPLayMode.Defender)
        {
            if (animator.gameObject.GetComponent<StateManager>().needToReturnOriginPosition)
            {
                animator.gameObject.GetComponent<StateManager>().returnOriginPosition();
            }
        }

        //

        // bool isAttacker = animator.gameObject.GetComponent<StateManager>().MyEnumMode == StateManager.EnumMode.Attack;
        // bool needPassBall = animator.gameObject.GetComponent<StateManager>().needPassBall;
        // bool isHaveBall = animator.gameObject.GetComponent<StateManager>().isHaveBall;
        // if (isHaveBall && isHaveBall && isAttacker)
        // {

        //     animator.gameObject.GetComponent<StateManager>().moveBallToAttacker(animator.gameObject.GetComponent<StateManager>().BallObject,
        //     animator.gameObject.GetComponent<StateManager>().nearestAttacker, animator.gameObject.GetComponent<StateManager>().ballSpeed);

        // }
    }

    // OnStateExit is called before OnStateExit is called on any state inside this state machine
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called before OnStateMove is called on any state inside this state machine
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateIK is called before OnStateIK is called on any state inside this state machine
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMachineEnter is called when entering a state machine via its Entry Node
    //override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    //{
    //    
    //}

    // OnStateMachineExit is called when exiting a state machine via its Exit Node
    //override public void OnStateMachineExit(Animator animator, int stateMachinePathHash)
    //{
    //    
    //}


}