using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Destructible : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject eplosionPrefab;
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag != "bullet") return;
        var cellPosition  =tilemap.WorldToCell(col.transform.position) ;
        var tile = tilemap.GetTile(cellPosition);
        if (tile == null) return;
        tilemap.SetTile(cellPosition, null);
        Instantiate(eplosionPrefab, cellPosition + new Vector3(0.5f,0.5f,0), Quaternion.identity );
    }
}