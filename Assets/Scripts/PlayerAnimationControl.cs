using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    // Start is called before the first frame update

    [SerializeField] private CardinalDirections facing = CardinalDirections.South;
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking;

        if(Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            isWalking = false;
        }
        else
        {
            isWalking = true;
        }
           
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


        animator.SetBool("isWalking", isWalking);
        animator.SetInteger("WalkDirection", (int)facing);
    }
}
