using System;
using System.Diagnostics;
using System.IO;

namespace Asynchronization_and_Processes
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {

                Process ExternalProcess = new Process();

                //Opening the notepad as the program runs
                ExternalProcess.StartInfo.FileName = "Notepad.exe";
                ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                ExternalProcess.Start();
                var input = Console.ReadLine();

                //Notepad closes as user types 'k'
                if (input.Equals("k"))
                {
                    ExternalProcess.CloseMainWindow();
                }

                foreach (Process p in Process.GetProcesses())
                {
                    Console.Write("\r\nName: " + p.ProcessName + "ID: " + p.Id);

                    if (p.ProcessName.Equals("notepad"))
                    {
                        p.Kill();
                    }
                }

                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.Write("Exception: " + e.Message);
            }

            //We write text to this notepad file, or it creates a new one if not found, thats saved in the specified folder tree.
            //This happens as a user types 'f'. Select the folder path and enter text to try it yourself.
            var second_input = Console.ReadLine();
            if (second_input.Equals("f"))
            {

                try
                {

                    //Pass the filepath and filename to the StreamWriter Constructor
                    //Username blurred out for safety
                    StreamWriter sw = new StreamWriter("C:\\Users\\-----\\test.txt");
                    //Write a line of text

                    sw.WriteLine("We woooooooooorkin!");
                    //Write a second line of text

                    sw.WriteLine("Hello from the console class");

                    //Close the file
                    sw.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }

            }




        }
    }
}
