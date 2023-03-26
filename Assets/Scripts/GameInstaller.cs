using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private Warrior _warriorPrefab;
    [SerializeField] private Sword _swordPrefab;
    [SerializeField] private Bow _bowPrefab;

    public enum WeaponType
    {
        Sword,
        Bow
    }

    [SerializeField] private WeaponType _startingWeaponType;

    public override void InstallBindings()
    {
        switch (_startingWeaponType)
        {
            case WeaponType.Sword:
                Container.Bind<Weapon>().FromComponentInNewPrefab(_swordPrefab).AsSingle();
                break;
            case WeaponType.Bow:
                Container.Bind<Weapon>().FromComponentInNewPrefab(_bowPrefab).AsSingle();
                break;
        }

        Container.Bind<Warrior>().FromComponentInNewPrefab(_warriorPrefab).AsSingle();
    }
}