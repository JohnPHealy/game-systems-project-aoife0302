using UnityEngine;

/*
 * This script is a generic health component for
 * any item that needs to have health.  This can
 * be added to the player, enemies, pots or grass
 * in the scene.  It can also be extended by
 * inheriting from it for specific interactions desired.
 */

public class GenericHealth : MonoBehaviour
{
    public FloatValue maxHealth;
    public float currentHealth;
    private float damage;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth.RuntimeValue;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void Heal(float amountToHeal)
    {
        currentHealth += amountToHeal;
        if (currentHealth > maxHealth.initialValue)
        {
            currentHealth = maxHealth.initialValue;
        }
    }

    public virtual void FullHeal()
    {
        currentHealth = maxHealth.initialValue;
    }

    public virtual void Damage(float amountToDamage)
    {
        currentHealth -= amountToDamage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    public virtual void InstantDeath()
    {
        currentHealth = 0;
    }

    public void Die()
    {
        if (currentHealth <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }


}
