using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable
{
    private Vector3 directionVector;
    private Transform myTransform;
    public float speed;
    private Rigidbody2D myRigidbody;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        myTransform = GetComponent<Transform>();
        myRigidbody = GetComponent<Rigidbody2D>();
        ChangeDirection();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        myRigidbody.MovePosition(myTransform.position + directionVector * speed * Time.deltaTime);

    }
    void ChangeDirection()
    {
        int direction = Random.Range(0,4);
        switch(direction)
        {
            case 0: 
            directionVector = Vector3.right;
            break; 
            case 1: 
            directionVector = Vector3.up; 
            break; 
            case 2: 
            directionVector = Vector3.left;
            break; 
            case 3: 
            directionVector = Vector3.down;
            break; 
            
        }
        UpdateAnimation();
    }
    void UpdateAnimation()
    {
        anim.SetFloat("MoveX", directionVector.x);
        anim.SetFloat("MoveY", directionVector.y);
    }
}
