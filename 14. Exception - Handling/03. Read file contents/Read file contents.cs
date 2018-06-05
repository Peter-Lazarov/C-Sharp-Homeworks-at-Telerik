using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.Read_file_contents
{
    class Program
    {
        static void Main()
        {
            try
            {
                string filepath = @"C:\WINDOWS\win.ini";//@"D:\Shared\proba.txt";
                string openfile = File.ReadAllText(filepath);
                Console.WriteLine(openfile);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("File location is too short or contains invalid characters");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("File location is too long");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("File location not found");
            }
            catch (IOException)
            {
                Console.WriteLine("Device contains file may be damaged, try to reconnect it and try again");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("File is a read only or not have permision to read it");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("File path is in wrong format try with \\");
            }
        }
    }
}
