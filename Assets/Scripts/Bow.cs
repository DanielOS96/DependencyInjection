using UnityEngine;

public class Bow : Weapon
{
    public override void Attack()
    {
        Debug.Log($"Shooting bow with {GetDamage()} damage");
    }
}
