using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public float limit1;
    public float limit2;
    public float speed;
    public Vector3 moveDirection;
    

    void Start()
    {
   
        moveDirection.x = 0.05f;
    }

    void Update()
    {
        transform.Translate(moveDirection, Space.World);     
        if(transform.position.x < limit1)
        {
            moveDirection.x = 0.05f;
        }
        if (transform.position.x > limit2)
        {
            moveDirection.x = -0.05f;
        }
    }
}
