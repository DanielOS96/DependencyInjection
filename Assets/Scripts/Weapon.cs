using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Weapon is an abstract base class representing different weapon types
// Using this base class along with Dependency Injection allows us to easily
// switch between different weapon implementations without changing the Warrior class
public abstract class Weapon : MonoBehaviour
{
    // The damage of the weapon
    [SerializeField] private int _damage;

    // Method to get the weapon's damage
    public int GetDamage()
    {
        return _damage;
    }

    // Abstract method for the attack behavior of the weapon
    // Each derived class (Sword, Bow, etc.) will need to implement its own attack behavior
    public abstract void Attack();
}

