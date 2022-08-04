using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D body;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    public GameObject bulletPrefab;
    const int UP = 0;
    const int DOWN = 1;
    const int LEFT = 2;
    const int RIGHT = 3;
    float shotCooldown = 0;
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

        body.velocity = velocity * (Time.deltaTime * 100);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }
    }

    private void Shot()
    {
        if (shotCooldown <Time.time)
        {
            shotCooldown = Time.time + 0.5f;
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            if (animator.GetInteger("direction") == UP)
            {
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * 10;
                bullet.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if (animator.GetInteger("direction") == DOWN)
            {
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * 10;
                bullet.transform.rotation = Quaternion.Euler(0, 0, 180);
            }
            else if (animator.GetInteger("direction") == LEFT)
            {
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0) * 10;
                bullet.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            else if (animator.GetInteger("direction") == RIGHT)
            {
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * 10;
                bullet.transform.rotation = Quaternion.Euler(0, 0, -90);
            }
        }
    }
}