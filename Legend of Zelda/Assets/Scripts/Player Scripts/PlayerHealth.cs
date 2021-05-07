using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : GenericHealth
{
    [SerializeField] private SignalGame healthSignal;
    public GameObject playerParent;


    [SerializeField]
    private GameObject Background;
    // Start is called before the first frame update

    public override void Damage(float amountToDamage)
    {
        base.Damage(amountToDamage);
        maxHealth.RuntimeValue = currentHealth;
        healthSignal.Raise();

        if (currentHealth <= 0) { 
            playerParent.SetActive(false);
            GameOver();
        }
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER");
        Background.SetActive(true);
    }
}
