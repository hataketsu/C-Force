using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera : MonoBehaviour
{
    public Transform target;
    public GameObject enemyPrefab;
    void Update()
    {
        if (target != null)
        {
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Stage1");
        }
        if (Random.Range(0, 200) < 1 || Input.GetKeyDown(KeyCode.Tab)) {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-5, 2), Random.Range(-4, 2), 0), Quaternion.identity);
            Debug.Log("Enemy Spawned");
        }
    }
}
