// See https://aka.ms/new-console-template for more information
using MenuBuilder;

IMenuInputHandler inputHandler = new NumberInputHandler();
IMenu mainMenu = new MainMenu(inputHandler);


mainMenu.Commands.Add("Store new missile/s", new DefaultCommand());
mainMenu.Commands.Add("Launch Missiles", new DefaultCommand());
mainMenu.Commands.Add("Inventory report", new DefaultCommand());
mainMenu.Commands.Add("Clean out missiles", new DefaultCommand());
mainMenu.Commands.Add("Shutdown the S6ML", new DefaultCommand());


mainMenu.showMenu();