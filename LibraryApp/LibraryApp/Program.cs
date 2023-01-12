﻿
using LibraryApp.Controllers;
using ServiceLayer.Helpers;

LibraryController libraryController= new();

while (true)
{
    GetOptions();
  
    Option: string option = Console.ReadLine();

    int selectedOption;

    bool isCorrectOption = int.TryParse(option, out selectedOption);

    if (isCorrectOption)
    {
        switch (selectedOption)
        {
            case 1:
                libraryController.Create();
                break;
            case 2:
                Console.WriteLine("Get All");
                break;
            case 3:
                Console.WriteLine("Delete");
                break;
            default:
                ConsoleColor.Red.WriteConsole("Please add correct option");
                goto Option;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Please add correct format option");
    }


}

static void GetOptions()
{
    ConsoleColor.Cyan.WriteConsole("Please selected one option :");
    ConsoleColor.Cyan.WriteConsole("Library options: 1 - Create , 2 - Get All , 3 - Delete");
}

