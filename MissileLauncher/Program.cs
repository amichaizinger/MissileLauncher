// See https://aka.ms/new-console-template for more information
using MenuBuilder;
using MissileLauncher;
using MissileLauncher.Interfaces;
using MissileLauncher.LaunchTechnic;
using MissileLauncher.MenuCommand;
using MissileLauncher.Missiles;

IMenuInputHandler inputHandler = new NumberInputHandler();
IMenu mainMenu = new MainMenu(inputHandler);

IMissileBattery missileBattery = new MissileBattery();

ILaunchTechnic manuallaunchTechnic = new ManualLaunch();
ILaunchTechnic legendaryLaunchTechnic = new LegendaryLaunch();
ILaunchTechnic remoteLaunchTechnic = new RemoteLaunch();

missileBattery.AddMissileType("Torpedo", new Torpedo(legendaryLaunchTechnic));
missileBattery.AddMissileType("Balistic", new Balistic(manuallaunchTechnic));
missileBattery.AddMissileType("Cruise", new Cruise(remoteLaunchTechnic));


mainMenu.Commands.Add("Store new missile/s", new AddMissilesCommand(missileBattery));
mainMenu.Commands.Add("Launch Missiles", new LaunchMissilesCommand(missileBattery));
mainMenu.Commands.Add("Inventory report", new DefaultCommand());
mainMenu.Commands.Add("Clean out missiles", new DefaultCommand());


mainMenu.showMenu();