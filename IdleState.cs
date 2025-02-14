using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IdleState : StateMachineBehaviour
{
        float timer;
    Transform player;
    

  
override public void  OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
{

timer = 0;
player = GameObject.FindGameObjectWithTag("Player").transform;

}

 override public void OnStateUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
{
  timer += Time.deltaTime;

  float distance = Vector3.Distance(player.position, animator.transform.position );

  if (distance < 30)
  {

    animator.SetBool("isChasing", true);
    
  }



}







}
