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

IMissile torpedo = new Torpedo(legendaryLaunchTechnic, "Torpedo");
IMissile balistic = new Balistic(manuallaunchTechnic, "Balistic");
IMissile cruise = new Cruise(remoteLaunchTechnic, "Cruise");

missileBattery.AddMissileType(torpedo.Name, torpedo);
missileBattery.AddMissileType(balistic.Name, balistic);
missileBattery.AddMissileType(cruise.Name, cruise );


mainMenu.Commands.Add("Store new missile/s", new MissileAdderCommand(missileBattery));
mainMenu.Commands.Add("Launch Missiles", new LaunchMissilesCommand
    (missileBattery));
mainMenu.Commands.Add("Inventory report", new InventoryPrinterCommand(missileBattery));
mainMenu.Commands.Add("Clean out missiles", new MissileDisposalCommand(missileBattery));


mainMenu.showMenu();