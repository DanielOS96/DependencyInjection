# Unity Dependency Injection Example

This Unity project demonstrates the use of Dependency Injection (DI) in a simple game scenario involving a warrior and different weapon types. The project uses [Zenject](https://github.com/modesttree/Zenject) for handling DI in Unity.

## Overview

The project consists of a warrior that can use different weapons, such as a sword or a bow. The weapons and warrior are implemented using the following classes:

- `Weapon`: An abstract base class for all weapon types.
- `Sword`: A concrete implementation of the `Weapon` class.
- `Bow`: Another concrete implementation of the `Weapon` class.
- `Warrior`: A class representing the warrior character, which depends on the `Weapon` class.

The project also includes a `GameInstaller` class that configures the DI bindings and a `WarriorController` class that controls the warrior's actions in the game.

## Benefits of Dependency Injection

Using DI in this project provides the following benefits:

1. **Loose coupling**: By injecting dependencies (like the Weapon instance) into the Warrior, we create a loose coupling between the Warrior and the Weapon. This makes it easier to change or extend the Weapon class without affecting the Warrior class.

2. **Easier testing**: Using DI makes it easier to test individual components in isolation. In our example, we can test the Warrior class without needing an actual Weapon implementation by injecting a mock or stub Weapon instance during testing.

3. **Flexibility**: In this project, we used DI to switch between different weapon types (Sword and Bow) easily. If we used interfaces alone without DI, we would need to implement a more complex mechanism for creating and managing different weapon instances.

4. **Centralized configuration**: With DI, we centralize the configuration and management of dependencies in the `GameInstaller` class. This makes it easier to understand and manage the relationships between components in the project.
