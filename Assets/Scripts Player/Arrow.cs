using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 30f;
    public float damage = 25f;
    public float destroyDelay = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        Destroy(gameObject, destroyDelay);
    }

    void Update()
    {
        if (rb.velocity.sqrMagnitude > 0.1f)
        {
            // ?�y l� ?o?n quan tr?ng: Xoay m?i t�n theo h??ng velocity
            Quaternion rotation = Quaternion.LookRotation(rb.velocity);
            // Offset 90 ?? ?? m?i t�n "n?m ngang" ?�ng chi?u
            transform.rotation = rotation * Quaternion.Euler(90, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        EnemyHealth enemy = collision.collider.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
