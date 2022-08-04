using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunner : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject player;
    public GameObject bulletPrefab;
    void Update()
    {
        transform.LookAt(player.transform);
    }

}
