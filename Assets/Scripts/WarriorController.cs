using UnityEngine;
using Zenject;

public class WarriorController : MonoBehaviour
{
    private Warrior _warrior;

    [Inject]
    public void Construct(Warrior warrior)
    {
        _warrior = warrior;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _warrior.PerformAttack();
        }
    }
}