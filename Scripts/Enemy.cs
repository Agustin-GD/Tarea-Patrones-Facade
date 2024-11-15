using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private CombatFacade enemyCombatFacade;

    void Start()
    {
        Debug.Log("Jajasdas");

        AttackEffects attackEffects = GetComponent<AttackEffects>();
        enemyCombatFacade = gameObject.AddComponent<CombatFacade>();
        enemyCombatFacade.Initialize(100);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Jajasdas");

        Player player = other.gameObject.GetComponent<Player>();
        
        if (player != null)
        {
            Debug.Log("Jaj");
            player.combatFacade.TakeDamage(enemyCombatFacade.Attack(10)); 
        }
    }
}