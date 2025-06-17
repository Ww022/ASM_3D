using UnityEngine;

public class BowShooter : MonoBehaviour
{
    public GameObject arrowPrefab;          // Prefab m?i tên
    public Transform arrowSpawnPoint;       // V? trí b?n ra (g?n vào tay/cung)
    public float arrowForce = 30f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Chu?t trái
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
