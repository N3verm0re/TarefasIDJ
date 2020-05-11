using System;
using System.Collections.Generic;
using System.IO;
using WeaponSystem;

namespace ConfigureManufacturer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Load if you wish to load and edit an existing Json with Manufacturers or Type New to create a new list of Manufacturers. Type Exit to leave the program.");
            string firstCommand = Console.ReadLine();

            while(firstCommand.ToLower() != "exit")
            {
                if (firstCommand.ToLower() == "load")
                {
                    Console.WriteLine("Enter file path (or file name if it is already located in bin/debug/netcoreapp3.1):");
                    string path = Console.ReadLine();
                    Dictionary<string, Manufacturer> manufacturerList = null;
                    bool validFile = true;

                    do
                    {
                        try
                        {
                            manufacturerList = ManufacturerParser.DeserializeJson(path);
                            validFile = true;
                        }
                        catch (DirectoryNotFoundException e)
                        {
                            Console.WriteLine($"File path not found. {e.Message}");
                            validFile = false;
                        }
                        catch (ArgumentNullException e)
                        {
                            Console.WriteLine($"File path not valid. {e.Message}");
                            validFile = false;
                        }
                        catch (UnauthorizedAccessException e)
                        {
                            Console.WriteLine($"File path not valid or file not valid. {e.Message}");
                            validFile = false;
                        }

                        if (!validFile) { break; }
                        if (manufacturerList == null || manufacturerList.Count == 0)
                        {
                            Confirmation:
                            Console.WriteLine("Your Manufacturer List is empty, the file might not have been loaded correctly. Do you wish to continue? Y/N");
                            string confirmation = Console.ReadLine();
                            if (confirmation.ToLower() != "y" && confirmation.ToLower() != "n")
                            {
                                Console.WriteLine("Insert Valid Option...");
                                goto Confirmation;
                            }
                            else if(confirmation.ToLower() == "n") { break; }
                        }

                        Console.WriteLine("Type New to begin add a new Manufacturer to the list, type Remove to remove a Manufacturer from the list, or type Save to save your current list of Manufacturers");
                        string secondCommand = Console.ReadLine();

                        while (secondCommand.ToLower() != "save")
                        {
                            if (secondCommand.ToLower() == "new")
                            {
                                Manufacturer newManufacturer = new Manufacturer();

                                Console.WriteLine("Enter your manufacturer's name:");
                                string name = Console.ReadLine();

                                Console.WriteLine("Enter your sniper sight's zoom and recoil modifier (in that order):");
                                newManufacturer.sniperSightsMod.Add("ZoomMod", double.Parse(Console.ReadLine()));
                                newManufacturer.sniperSightsMod.Add("RecoilMod", double.Parse(Console.ReadLine()));

                                Console.WriteLine("Enter your normal weapon sight's zoom and recoil modifier (in that order):");
                                newManufacturer.sightsMod.Add("ZoomMod", double.Parse(Console.ReadLine()));
                                newManufacturer.sightsMod.Add("RecoilMod", double.Parse(Console.ReadLine()));

                                Console.WriteLine("Enter your barrel's damage and Rate of Fire modifiers (in that order):");
                                newManufacturer.barrelMod.Add("DamageMod", double.Parse(Console.ReadLine()));
                                newManufacturer.barrelMod.Add("RPMMod", double.Parse(Console.ReadLine()));

                                Console.WriteLine("Enter your weapon stock's Hip Fire Innacuracy and ADS Time modifier's (in that order):");
                                newManufacturer.stockMod.Add("HipFireMod", double.Parse(Console.ReadLine()));
                                newManufacturer.stockMod.Add("ADSTimeMod", double.Parse(Console.ReadLine()));

                                Console.WriteLine("Enter your magazine's ammo count and reload speed modifiers (in that order):");
                                newManufacturer.magazineMod.Add("AmmoCountMod", double.Parse(Console.ReadLine()));
                                newManufacturer.magazineMod.Add("ReloadSpeedMod", double.Parse(Console.ReadLine()));

                                manufacturerList.Add(name, newManufacturer);
                            }
                            else if (secondCommand.ToLower() == "remove")
                            {
                                if (manufacturerList == null || manufacturerList.Count == 0)
                                {
                                    Console.WriteLine("Manufacturer List Empty! Cant remove anything...");
                                }
                                else
                                {
                                    Dictionary<string, Manufacturer>.KeyCollection keys = manufacturerList.Keys;
                                    Console.WriteLine("Current List of Manufacturers:");
                                    foreach(string s in keys)
                                    {
                                        Console.WriteLine(s);
                                    }

                                    Console.WriteLine("Insert the name of the Manufacturer you want to delete or Exit to leave the remove option");
                                    string removeCommand = Console.ReadLine();

                                    while(removeCommand.ToLower() != "exit")
                                    {
                                        try
                                        {
                                            if(manufacturerList.TryGetValue(removeCommand, out Manufacturer value))
                                            {
                                                manufacturerList.Remove(removeCommand);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Manufacturer not found, try again.");
                                            }
                                        }
                                        catch(ArgumentNullException e)
                                        {
                                            Console.WriteLine($"Invalid Manufacturer name. {e.Message}");
                                        }

                                        Console.WriteLine("Insert the name of the Manufacturer you want to delete or Exit to leave the remove option");
                                        removeCommand = Console.ReadLine();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Command invalid, try again");
                            }

                            Console.WriteLine("Type New to begin add a new Manufacturer to the list, or type Save to save your current list of Manufacturers");
                            secondCommand = Console.ReadLine();
                        }

                        ManufacturerParser.SerializeJson(manufacturerList, path);
                        break;

                    } while (validFile);
                }
                else if (firstCommand.ToLower() == "new")
                {
                    Dictionary<string, Manufacturer> manufacturerList = new Dictionary<string, Manufacturer>();
                    Console.WriteLine("Type New to begin add a new Manufacturer to the list, or type Save to save your current list of Manufacturers");
                    string secondCommand = Console.ReadLine();

                    while(secondCommand.ToLower() != "save")
                    {
                        if(secondCommand.ToLower() == "new")
                        {
                            Manufacturer newManufacturer = new Manufacturer();

                            Console.WriteLine("Enter your manufacturer's name:");
                            string name = Console.ReadLine();

                            Console.WriteLine("Enter your sniper sight's zoom and recoil modifier (in that order):");
                            newManufacturer.sniperSightsMod.Add("ZoomMod", double.Parse(Console.ReadLine()));
                            newManufacturer.sniperSightsMod.Add("RecoilMod", double.Parse(Console.ReadLine()));

                            Console.WriteLine("Enter your normal weapon sight's zoom and recoil modifier (in that order):");
                            newManufacturer.sightsMod.Add("ZoomMod", double.Parse(Console.ReadLine()));
                            newManufacturer.sightsMod.Add("RecoilMod", double.Parse(Console.ReadLine()));

                            Console.WriteLine("Enter your barrel's damage and Rate of Fire modifiers (in that order):");
                            newManufacturer.barrelMod.Add("DamageMod", double.Parse(Console.ReadLine()));
                            newManufacturer.barrelMod.Add("RPMMod", double.Parse(Console.ReadLine()));

                            Console.WriteLine("Enter your weapon stock's Hip Fire Innacuracy and ADS Time modifier's (in that order):");
                            newManufacturer.stockMod.Add("HipFireMod", double.Parse(Console.ReadLine()));
                            newManufacturer.stockMod.Add("ADSTimeMod", double.Parse(Console.ReadLine()));

                            Console.WriteLine("Enter your magazine's ammo count and reload speed modifiers (in that order):");
                            newManufacturer.magazineMod.Add("AmmoCountMod", double.Parse(Console.ReadLine()));
                            newManufacturer.magazineMod.Add("ReloadSpeedMod", double.Parse(Console.ReadLine()));

                            manufacturerList.Add(name, newManufacturer);
                        }
                        else
                        {
                            Console.WriteLine("Command invalid, try again");
                        }

                        Console.WriteLine("Type New to begin add a new Manufacturer to the list, or type Save to save your current list of Manufacturers");
                        secondCommand = Console.ReadLine();
                    }

                    ManufacturerParser.SerializeJson(manufacturerList);
                }
                else
                {
                    Console.WriteLine("Invalid command, try again");
                }

                Console.WriteLine("Type Load if you wish to load and edit an existing Json with Manufacturers or Type New to create a new list of Manufacturers. Type Exit to leave the program.");
                firstCommand = Console.ReadLine();
            }
        }
    }
}
