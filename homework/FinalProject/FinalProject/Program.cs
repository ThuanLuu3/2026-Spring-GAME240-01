using System;

enum Room
{
    Entrance,
    LivingRoom,
    Garden,
    Library,
    BathRoom,
    BedRoom,
    StudyRoom,
    StorageRoom,
    TreasureRoom
}

class Program
{
    static void Main(string[] args)
    {
        Room currentRoom = Room.Entrance;

        bool hasFlashlight = false;
        bool hasKey = false;
        bool hasHammer = false;
        bool treasureDoorUnlocked = false;
        bool gameRunning = true;

        Console.WriteLine("Welcome to my World :)))");

        while (gameRunning)
        {
            ShowRoom(currentRoom, treasureDoorUnlocked,
                     hasFlashlight, hasKey, hasHammer);

            Console.WriteLine("\nWhat would you like to do?");
            string input = Console.ReadLine().ToLower();

            string[] splitInput = input.Split(' ');

            if (splitInput.Length < 2)
            {
                Console.WriteLine("Please type correctly.");
                continue;
            }

            string command = splitInput[0];
            string additionalInfo = splitInput[1];

            switch (command)
            {
                case "move":

                    switch (currentRoom)
                    {
                        case Room.Entrance:

                            if (additionalInfo == "north")
                            {
                                currentRoom = Room.LivingRoom;
                            }
                            else if (additionalInfo == "south")
                            {
                                currentRoom = Room.BathRoom;
                            }
                            else if (additionalInfo == "east")
                            {
                                currentRoom = Room.StorageRoom;
                            }
                            else if (additionalInfo == "west")
                            {
                                currentRoom = Room.Library;
                            }
                            else
                            {
                                Console.WriteLine("You can't move there.");
                            }

                            break;

                        case Room.LivingRoom:

                            if (additionalInfo == "south")
                            {
                                currentRoom = Room.Entrance;
                            }
                            else if (additionalInfo == "west")
                            {
                                currentRoom = Room.Garden;
                            }
                            else
                            {
                                Console.WriteLine("You can't move there.");
                            }

                            break;

                        case Room.Garden:

                            if (additionalInfo == "east")
                            {
                                currentRoom = Room.LivingRoom;
                            }
                            else
                            {
                                Console.WriteLine("You can't move there.");
                            }

                            break;

                        case Room.Library:

                            if (additionalInfo == "east")
                            {
                                currentRoom = Room.Entrance;
                            }
                            else if (additionalInfo == "west")
                            {
                                if (hasFlashlight)
                                {
                                    currentRoom = Room.StudyRoom;
                                }
                                else
                                {
                                    Console.WriteLine("It is too dark.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You can't move there.");
                            }

                            break;

                        case Room.StudyRoom:

                            if (additionalInfo == "east")
                            {
                                currentRoom = Room.Library;
                            }
                            else
                            {
                                Console.WriteLine("You can't move there.");
                            }

                            break;

                        case Room.StorageRoom:

                            if (additionalInfo == "west")
                            {
                                currentRoom = Room.Entrance;
                            }
                            else if (additionalInfo == "east")
                            {
                                if (treasureDoorUnlocked)
                                {
                                    currentRoom = Room.TreasureRoom;
                                }
                                else
                                {
                                    Console.WriteLine("The Treasure Room is locked.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("You can't move there.");
                            }

                            break;

                        case Room.TreasureRoom:

                            if (additionalInfo == "west")
                            {
                                currentRoom = Room.StorageRoom;
                            }
                            else
                            {
                                Console.WriteLine("You can't move there.");
                            }

                            break;

                        case Room.BathRoom:

                            if (additionalInfo == "north")
                            {
                                currentRoom = Room.Entrance;
                            }
                            else if (additionalInfo == "west")
                            {
                                currentRoom = Room.BedRoom;
                            }
                            else
                            {
                                Console.WriteLine("You can't move there.");
                            }

                            break;

                        case Room.BedRoom:

                            if (additionalInfo == "east")
                            {
                                currentRoom = Room.BathRoom;
                            }
                            else
                            {
                                Console.WriteLine("You can't move there.");
                            }

                            break;
                    }

                    break;

                case "take":

                    if (additionalInfo == "flashlight" &&
                        currentRoom == Room.LivingRoom)
                    {
                        if (!hasFlashlight)
                        {
                            hasFlashlight = true;
                            Console.WriteLine("You took the flashlight.");
                        }
                        else
                        {
                            Console.WriteLine("You already have the flashlight.");
                        }
                    }

                    else if (additionalInfo == "key" &&
                             currentRoom == Room.StudyRoom)
                    {
                        if (!hasKey)
                        {
                            hasKey = true;
                            Console.WriteLine("You took the key.");
                        }
                        else
                        {
                            Console.WriteLine("You already have the key.");
                        }
                    }

                    else if (additionalInfo == "hammer" &&
                             currentRoom == Room.StorageRoom)
                    {
                        if (!hasHammer)
                        {
                            hasHammer = true;
                            Console.WriteLine("You took the hammer.");
                        }
                        else
                        {
                            Console.WriteLine("You already have the hammer.");
                        }
                    }

                    else
                    {
                        Console.WriteLine("That item is not here.");
                    }

                    break;

                case "use":

                    if (additionalInfo == "flashlight")
                    {
                        if (hasFlashlight)
                        {
                            Console.WriteLine("You turn on the flashlight.");
                        }
                        else
                        {
                            Console.WriteLine("You do not have a flashlight.");
                        }
                    }

                    else if (additionalInfo == "key")
                    {
                        if (hasKey &&
                            currentRoom == Room.StorageRoom)
                        {
                            treasureDoorUnlocked = true;

                            Console.WriteLine("You unlocked the Treasure Room!");
                        }
                        else
                        {
                            Console.WriteLine("You cannot use the key here.");
                        }
                    }

                    else if (additionalInfo == "hammer")
                    {
                        if (hasHammer &&
                            currentRoom == Room.TreasureRoom)
                        {
                            Console.WriteLine("You broke open the treasure!");
                            Console.WriteLine("Congratulations! You win!");

                            gameRunning = false;
                        }
                        else
                        {
                            Console.WriteLine("You cannot use the hammer here.");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid item.");
                    }

                    break;

                default:

                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }

    private static void ShowRoom(
        Room currentRoom,
        bool treasureDoorUnlocked,
        bool hasFlashlight,
        bool hasKey,
        bool hasHammer)
    {
        Console.WriteLine("\n----------------------");

        switch (currentRoom)
        {
            case Room.Entrance:

                Console.WriteLine("You are in the Main Entrance.");
                Console.WriteLine("Exits: North, South, East, West");

                break;

            case Room.LivingRoom:

                Console.WriteLine("You are in the Living Room.");

                if (!hasFlashlight)
                {
                    Console.WriteLine("There is a flashlight here.");
                }

                Console.WriteLine("Exits: South, West");

                break;

            case Room.Garden:

                Console.WriteLine("You are in the Garden.");
                Console.WriteLine("Exit: East");

                break;

            case Room.Library:

                Console.WriteLine("You are in the Library.");
                Console.WriteLine("It is dark inside.");
                Console.WriteLine("Exits: East, West");

                break;

            case Room.StudyRoom:

                Console.WriteLine("You are in the Study Room.");

                if (!hasKey)
                {
                    Console.WriteLine("There is a key on the desk.");
                }

                Console.WriteLine("Exit: East");

                break;

            case Room.BathRoom:

                Console.WriteLine("You are in the Bathroom.");
                Console.WriteLine("Exits: North, West");

                break;

            case Room.BedRoom:

                Console.WriteLine("You are in the Bedroom.");
                Console.WriteLine("Exit: East");

                break;

            case Room.StorageRoom:

                Console.WriteLine("You are in the Storage Room.");

                if (!hasHammer)
                {
                    Console.WriteLine("There is a hammer here.");
                }

                if (treasureDoorUnlocked)
                {
                    Console.WriteLine("The Treasure Room is unlocked to the East.");
                }
                else
                {
                    Console.WriteLine("There is a locked Treasure Room to the East.");
                    Console.WriteLine("Use key to open it");
    
                }

                Console.WriteLine("Exits: West, East");

                break;

            case Room.TreasureRoom:

                Console.WriteLine("You are in the Treasure Room.");
                Console.WriteLine("A large treasure chest is in front of you.");
                Console.WriteLine("Use a hammer here.");

                break;
        }
    }
}