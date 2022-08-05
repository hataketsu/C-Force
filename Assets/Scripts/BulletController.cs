using System;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject bigExplosionPrefab;
    private float readyTime;

    private void Start()
    {
        readyTime = Time.time + 0.1f;
        Destroy(gameObject, 2f);
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (readyTime > Time.time)
            return;
        switch (col.gameObject.name)
        {
            case "FlatObjects":
                return;
            case "Objects":
                Destroy(gameObject);
                Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
                break;
            default:
                Destroy(col.gameObject);
                Destroy(gameObject);
                Instantiate(bigExplosionPrefab, col.gameObject.transform.position, Quaternion.identity);
                break;
        }
    }
}