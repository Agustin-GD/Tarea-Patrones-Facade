using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculator : MonoBehaviour
{
    public int CalculateDamage(int baseDamage)
    {
        int randomFactor = Random.Range(0, 5);
        return baseDamage + randomFactor;
    }
}
