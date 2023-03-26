using UnityEngine;
using Zenject;

public class WarriorController : MonoBehaviour
{
    private Warrior _warrior;

    // This method is called by Zenject to inject the Warrior instance
    // Using Dependency Injection, we don't need to manually create the Warrior,
    // Zenject takes care of it and provides the instance for us
    [Inject]
    public void Construct(Warrior warrior)
    {
        _warrior = warrior;
    }

    private void Update()
    {
        // When the Space key is pressed, perform the warrior's attack
        // This demonstrates how we can use the injected Warrior instance
        // without needing to know which specific weapon the warrior has
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _warrior.PerformAttack();
        }
    }
}