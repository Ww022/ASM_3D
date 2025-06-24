using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public PlayerHealthUI healthUI;

    void Start()
    {
        currentHealth = maxHealth;
        healthUI.SetHealth(currentHealth, maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;

        healthUI.SetHealth(currentHealth, maxHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Player died");
        }
    }
}
