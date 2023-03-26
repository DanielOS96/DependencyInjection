using UnityEngine;
using Zenject;

public class Warrior : MonoBehaviour
{
    private Weapon _weapon;

    [Inject]
    public void Construct(Weapon weapon)
    {
        _weapon = weapon;
    }

    public void PerformAttack()
    {
        _weapon.Attack();
    }
}
