using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D myRigidBody; 
    private Vector3 change; 
    private Animator animator;
    public FloatValue currentHealth; 
    public Sig playerHealthSig;

    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationAndMove();
        
    }
    void UpdateAnimationAndMove(){
        if(change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }else{
            animator.SetBool("moving", false);
        }
    }
    void MoveCharacter()
    {
        myRigidBody.MovePosition(
            transform.position + change * speed * Time.deltaTime
        );
    }
    public void Knock(int baseAttack) {
        currentHealth.initValue -= baseAttack; 
        if(currentHealth.initValue > 0 ){
            playerHealthSig.Raise(); 
        }
    }
}
