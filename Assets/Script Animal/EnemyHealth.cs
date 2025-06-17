using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"{gameObject.name} b? trúng tên, còn {health} máu");

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log($"{gameObject.name} ?ã ch?t");
        Destroy(gameObject); // Xoá ??i t??ng sau khi ch?t
    }
}
