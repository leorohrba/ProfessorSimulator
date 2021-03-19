using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] CharacterController player;

    [SerializeField] float runSpeed = 40f;

    float horizontalMove = 0;
    float verticalMove = 0;

    Vector3 movePosition;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        getDirection();
    }

    private void FixedUpdate()
    {
        move();
    }

    void getDirection()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        verticalMove = Input.GetAxisRaw("Vertical") * runSpeed;
    }
    void move()
    {
        movePosition.x = horizontalMove;

        movePosition.y = verticalMove;

        //movePosition.Normalize();

        player.Move(movePosition * Time.fixedDeltaTime);

        changeSprite();
        
    }
    void changeSprite()
    {
        if (horizontalMove != 0 || verticalMove != 0)
        {
            if (horizontalMove < 0)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

}
