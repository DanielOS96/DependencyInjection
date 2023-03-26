using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sword is a concrete implementation of the Weapon class
// This demonstrates how we can create different weapon types by inheriting from the Weapon base class
// Using this approach with Dependency Injection makes it easy to switch between different weapon types in the Warrior class

public class Sword : Weapon
{
    // The attack range of the sword
    [SerializeField] private float _attackRange;

    // Override the abstract Attack method from the Weapon base class
    // This provides a specific implementation for the sword's attack behavior
    public override void Attack()
    {
        // Implement the sword's attack logic here
        // For example: swing the sword, deal damage to enemies within the attack range, etc.

        Debug.Log($"Swinging the sword with {_attackRange} range and {GetDamage()} damage");
    }
}
