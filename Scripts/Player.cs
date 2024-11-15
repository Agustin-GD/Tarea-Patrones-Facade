using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CombatFacade combatFacade;

    void Start()
    {
        combatFacade = gameObject.AddComponent<CombatFacade>();
        combatFacade.Initialize(100);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            combatFacade.Attack(10);
        }
    }
}
