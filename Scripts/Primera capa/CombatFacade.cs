using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatFacade : MonoBehaviour
{
    private HealthSystem healthSystem;
    private DamageCalculator damageCalculator;
    private AttackEffects attackEffects;

    public void Initialize(int initialHealth)
    {
        healthSystem = gameObject.AddComponent<HealthSystem>();
        healthSystem.Initialize(initialHealth);

        damageCalculator = gameObject.AddComponent<DamageCalculator>();
        attackEffects = gameObject.AddComponent<AttackEffects>();
    }

    public int Attack(int baseDamage)
    {
        attackEffects.PlayAttackEffect();
        int damage = damageCalculator.CalculateDamage(baseDamage);
        return damage;
    }

    public void TakeDamage(int damage)
    {
        healthSystem.TakeDamage(damage);
    }
}
