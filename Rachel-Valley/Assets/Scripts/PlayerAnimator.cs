using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    private PlayerController playerController; 

    void Start()
    {
        animator = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
    }

    void Update()
    {
        bool isWalking = playerController.IsMoving();
        animator.SetBool("1_Move", isWalking);

        if (Input.GetMouseButtonDown(1)) 
        {
            animator.SetBool("2_Attack", true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            animator.SetBool("2_Attack", false);
        }
    }
}
