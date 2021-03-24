using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animatior;

    float horizantalMove = 0f;

    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;

    void Update()
    {
        horizantalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animatior.SetFloat("Speed", Mathf.Abs(horizantalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animatior.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    public void OnLanding()
    {
        
        animatior.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animatior.SetBool("IsCrouching", isCrouching);
    }

    private void FixedUpdate()
    {
        //move the character
        controller.Move(horizantalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        

    }
    
}
