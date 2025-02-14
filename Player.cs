using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController characterController;
   public float speed;
   public float gravity= -9.81f;
   public Vector3 Velocity;
   public float jump;
   public Animator anim;

   private void Update()
   {

    if(characterController.isGrounded && Velocity.y < 0)

    {
        anim.SetBool("isJumping",true);
        Velocity.y = 0;
        StartCoroutine(coroutine());

    }
    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(0.2f);

        anim.SetBool("isJumping", false);

    }

    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");

    Vector3 move = transform.right * x + transform.forward * z;

    characterController.Move(move*speed*Time.deltaTime);


    if (Input.GetButtonDown("Jump"))
    {
        Velocity.y = Mathf.Sqrt(jump * -2f * gravity);


    }

    Velocity.y += gravity * Time.deltaTime;
    characterController.Move(Velocity * Time.deltaTime);


   }


}