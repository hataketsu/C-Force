using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Destructible : MonoBehaviour
{
    public Tilemap tilemap;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Destructible" + col.gameObject.name + " " + col.gameObject.tag);
    }
}