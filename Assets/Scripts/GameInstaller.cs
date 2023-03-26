using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    // Assign the prefabs for Warrior, Sword, and Bow in the Unity inspector
    [SerializeField] private Warrior _warriorPrefab;
    [SerializeField] private Sword _swordPrefab;
    [SerializeField] private Bow _bowPrefab;

    // Enum to select the starting weapon type in the Unity inspector
    public enum WeaponType
    {
        Sword,
        Bow
    }

    // Assign the desired starting weapon type in the Unity inspector
    [SerializeField] private WeaponType _startingWeaponType;

    // This method is called by Zenject to set up the DI bindings
    public override void InstallBindings()
    {
        // Bind the selected weapon type (Sword or Bow) as a single instance
        switch (_startingWeaponType)
        {
            case WeaponType.Sword:
                // Using DI, we can easily switch between different weapon types
                Container.Bind<Weapon>().FromComponentInNewPrefab(_swordPrefab).AsSingle();
                break;
            case WeaponType.Bow:
                Container.Bind<Weapon>().FromComponentInNewPrefab(_bowPrefab).AsSingle();
                break;
        }

        // Bind the Warrior as a single instance
        Container.Bind<Warrior>().FromComponentInNewPrefab(_warriorPrefab).AsSingle();
    }

    // Other types of instances and how they might be used in an expanded project:
    // 
    // 1. Transient: Create a new instance of a class every time it's requested.
    //    - Useful if we want to spawn multiple warriors with different weapons
    //      without sharing the same weapon instance.
    //    Example: Container.Bind<Warrior>().AsTransient();
    //
    // 2. Cached: Create a separate instance for each concrete type requested.
    //    - Useful if we have multiple weapon implementations and want to have a
    //      single instance for each concrete weapon type.
    //    Example: Container.Bind<Weapon>().To<Sword>().AsCached();
    //             Container.Bind<Weapon>().To<Bow>().AsCached();
    //
    // 3. FromResolve: Use an existing instance in the container for a new binding.
    //    - Useful when we want to use an already resolved instance for a different
    //      binding without creating a new instance.
    //    Example: Container.Bind<Warrior>().AsSingle();
    //             Container.Bind<IWarrior>().FromResolve<Warrior>();

}