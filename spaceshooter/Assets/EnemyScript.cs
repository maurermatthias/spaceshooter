using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enemy generic behavior
/// </summary>
public class EnemyScript : MonoBehaviour
{
    private WeaponScript[] weapons;

    void Awake()
    {
        // Retrieve the weapon only once
        weapons = GetComponentsInChildren<WeaponScript>();
        if (weapons.Length==0) {
            Debug.Log("No weapons found!");
        }
    }

    void Update()
    {
        foreach (WeaponScript weapon in weapons)
        {
            // Auto-fire
            if (weapon != null && weapon.CanAttack)
            {
                weapon.Attack(true);
            }
        }
    }
}