using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    const int UP = 0;
    const int DOWN = 1;
    const int LEFT = 2;
    const int RIGHT = 3;

    private void Update()
    {
        var velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity = new Vector2(0, 1);
            animator.SetInteger("direction", UP);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity = new Vector2(0, -1);
            animator.SetInteger("direction", DOWN);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity = new Vector2(-1, 0);
            animator.SetInteger("direction", LEFT);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity = new Vector2(1, 0);
            animator.SetInteger("direction", RIGHT);
        }

        rigidbody2D.velocity = velocity * (Time.deltaTime * 100);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.color = Color.red;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            spriteRenderer.color = Color.white;
        }
    }
}