using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"{gameObject.name} b? tr�ng t�n, c�n {health} m�u");

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log($"{gameObject.name} ?� ch?t");
        Destroy(gameObject); // Xo� ??i t??ng sau khi ch?t
    }
}
