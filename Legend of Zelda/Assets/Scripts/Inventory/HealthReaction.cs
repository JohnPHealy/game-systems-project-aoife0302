using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthReaction : MonoBehaviour
{
    public FloatValue playerHealth;
    public SignalGame healthSignal;

    public void Use(int amountToIncrease)
    {
        playerHealth.RuntimeValue += amountToIncrease;
        healthSignal.Raise();
    }
}
