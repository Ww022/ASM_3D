using UnityEngine;

public class BowShooter : MonoBehaviour
{
    public GameObject arrowPrefab;          // Prefab m?i t�n
    public Transform arrowSpawnPoint;       // V? tr� b?n ra (g?n v�o tay/cung)
    public float arrowForce = 30f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Chu?t tr�i
        {
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, arrowSpawnPoint.rotation);
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        rb.velocity = arrowSpawnPoint.forward * arrowForce;
    }
}
