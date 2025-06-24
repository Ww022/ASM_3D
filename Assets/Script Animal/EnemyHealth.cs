using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    private int HP = 100;
    public Slider HPbar;
    private void Update()
    {
        HPbar.value = HP;
    }
    public void TakeDamage(float damage)
    {
        HP -= (int)damage;
        Debug.Log($"{gameObject.name} b? trúng tên, còn {HP} máu");

        if (HP <= 0)
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
