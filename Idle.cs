using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{
    float timer;
    Transform player;
  
public void  OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
{

timer = 0;
player = GameObject.FindGameObjectWithTag("Player").transform;

}

 public void OnStateUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
{
  timer += Time.deltaTime;

  float distance = Vector3.Distance(player.position, animator.transform.position );

  if (distance < 5)
  {

    animator.SetBool("isChasing", true);
  }




}








  }
