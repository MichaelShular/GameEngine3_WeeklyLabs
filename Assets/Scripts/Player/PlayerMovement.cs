using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed = 1.0f;
    Vector3 moveto;
    void Start()
    {
        
    }
    void Update()
    {
        //getting which direction player is moving to
        moveto = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0.0f);
        //updating player location over time
        transform.position += moveto * playerSpeed * Time.deltaTime;
    }
    
}
