using System;
using System.Collections.Generic;

namespace InheritanceOnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs to add:");
            int songQuantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("///////////////");
            Console.WriteLine("Please Insert you songs in the format <artist name>;<song name>;<minutes:seconds>");
            Console.WriteLine("///////////////");

            List<Song> songList = new List<Song>();

            for(int i = 0; i < songQuantity; i++)
            {
                bool next = true;
                int validCount = 0;
                while (next)
                {
                    validCount = 0;
                    Console.WriteLine($"Insert song Nº{i+1}:");
                    string songString = Console.ReadLine();
                    foreach (char identifier in songString)
                    {
                        if (identifier == ';' || identifier == ':')
                        {
                            validCount++;
                        }
                    }

                    if(validCount == 3)
                    {
                        try
                        {
                            songList.Add(new Song(songString));
                            Console.WriteLine("///////////////");
                            Console.WriteLine("Song added.");
                            Console.WriteLine("///////////////");
                            next = false;
                        }
                        catch (InvalidArtistNameException e)
                        {
                            Console.WriteLine("///////////////");
                            Console.WriteLine(e.Message);
                            Console.WriteLine("///////////////");
                            next = false;
                        }
                        catch (InvalidSongNameException e)
                        {
                            Console.WriteLine("///////////////");
                            Console.WriteLine(e.Message);
                            Console.WriteLine("///////////////");
                            next = false;
                        }
                        catch (InvalidSongMinutesException e)
                        {
                            Console.WriteLine("///////////////");
                            Console.WriteLine(e.Message);
                            Console.WriteLine("///////////////");
                            next = false;
                        }
                        catch (InvalidSongSecondsException e)
                        {
                            Console.WriteLine("///////////////");
                            Console.WriteLine(e.Message);
                            Console.WriteLine("///////////////");
                            next = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("///////////////");
                        Console.WriteLine("Input format is not valid! Make sure you have ';' seperating the parameters, that you are inputing all parameters and that you have ':' bewtween your song's minutes and seconds!");
                        Console.WriteLine("///////////////");
                    }
                }
            }

            int minutesTotal = 0;
            int secondsTotal = 0;

            Console.WriteLine(" ");

            for (int i = 0; i < songList.Count; i++)
            {
                Console.WriteLine($"/////Song Nº{i+1}/////");
                Console.WriteLine(songList[i]);
                minutesTotal += songList[i].LengthMinutes;
                secondsTotal += songList[i].LengthSeconds;
            }

            Console.WriteLine(" ");
            minutesTotal += Math.DivRem(secondsTotal, 60, out secondsTotal);
            Console.WriteLine("/////Song count and Playlist duration/////");
            Console.WriteLine($"Songs added: {songList.Count}");
            Console.WriteLine($"Playlist Length: {minutesTotal}:{secondsTotal}");
        }
    }
}
