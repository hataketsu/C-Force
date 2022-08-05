using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public GameObject tracePrefab;
    void Destroy()
    {
        if (tracePrefab != null)
        {
            Instantiate(tracePrefab, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}