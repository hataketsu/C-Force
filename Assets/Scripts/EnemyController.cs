using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Sprite UpSprite;
    public Sprite DownSprite;
    public Sprite LeftSprite;
    public Sprite RightSprite;
    public SpriteRenderer SpriteRenderer;
    public Rigidbody2D Rigidbody2D;
    public GameObject bulletPrefab;

    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    Direction direction = Direction.Up;

    private void Start()
    {
        ChangeDirection();
    }

    void Update()
    {
        if (Random.value < 0.01f)
        {
            ChangeDirection();
        }

        if (Random.value < 0.03f)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        switch (direction)
        {
            case Direction.Up:
                bullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
                break;
            case Direction.Down:
                bullet.GetComponent<Rigidbody2D>().velocity = Vector2.down * 10;
                break;
            case Direction.Left:
                bullet.GetComponent<Rigidbody2D>().velocity = Vector2.left * 10;
                break;
            case Direction.Right:
                bullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * 10;
                break;
        }
    }

    private void ChangeDirection()
    {
        direction = (Direction)Random.Range(0, 4);
        switch (direction)
        {
            case Direction.Up:
                SpriteRenderer.sprite = UpSprite;
                Rigidbody2D.velocity = Vector2.up;
                break;
            case Direction.Down:
                SpriteRenderer.sprite = DownSprite;
                Rigidbody2D.velocity = Vector2.down;
                break;
            case Direction.Left:
                SpriteRenderer.sprite = LeftSprite;
                Rigidbody2D.velocity = Vector2.left;
                break;
            case Direction.Right:
                SpriteRenderer.sprite = RightSprite;
                Rigidbody2D.velocity = Vector2.right;
                break;
        }
    }
}