using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject bigExplosionPrefab;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Bullet hit: " + col.gameObject.name);
        if (col.gameObject.name == "Player" || col.gameObject.name == "Gunner")
            return;
        if (col.gameObject.name == "Objects")
        {
            Destroy(gameObject);
            Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
        }
        else
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(bigExplosionPrefab, col.gameObject.transform.position, Quaternion.identity);
        }
    }
}