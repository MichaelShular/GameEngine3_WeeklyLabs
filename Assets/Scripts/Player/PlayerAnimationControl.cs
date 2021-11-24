using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// This script is used to control the animations clip of the player are suppose to play
/// 
///Version 0.1
///-check is player is moving  

public enum CardinalDirections
{
    North,
    East,
    South,
    West
}
public class PlayerAnimationControl : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool isWalking;
    // Start is called before the first frame update

    [SerializeField] private CardinalDirections facing = CardinalDirections.South;
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //to check if player has any movement  
        if(Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            isWalking = false;
        }
        else
        {
            isWalking = true;
        }
        
        //Dirction of animation if player is moving
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                facing = CardinalDirections.West;
            }
            else
            {
                facing = CardinalDirections.East;
            }
        }
        else
        {
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                facing = CardinalDirections.South;
            }
            else
            {
                facing = CardinalDirections.North;
            }
        }
        //sending information to animator to play animations
        animator.SetBool("isWalking", isWalking);
        animator.SetInteger("WalkDirection", (int)facing);
    }
}
