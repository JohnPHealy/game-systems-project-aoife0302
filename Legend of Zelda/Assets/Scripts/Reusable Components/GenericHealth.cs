using UnityEngine;

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
        if (currentHealth > maxHealth.intialValue)
        {
            currentHealth = maxHealth.intialValue;
        }
    }

    public virtual void FullHeal()
    {
        currentHealth = maxHealth.intialValue;
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
