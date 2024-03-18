using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Worm : Enemy
{
    private Rigidbody2D myRigidbody;
    public Transform target; 
    public float chaseRadius; 
    public float attackRadius; 
    public Transform homePosition; 

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
    }

    void CheckDistance()
    {
        if(Vector3.Distance(target.position, transform.position) <= chaseRadius 
           && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            // Move towards the player
            Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            myRigidbody.MovePosition(temp);
            
            // Flip towards the player's direction
            if (temp.x < transform.position.x)
            {
                // Player is on the left side, flip the enemy to face left
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                // Player is on the right side, flip the enemy to face right
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }
    
}
