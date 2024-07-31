using System.Diagnostics; //Import needed to use the Process class
namespace LUI_Process_Demo_G1
{//namespace begin
    internal class Program
    {//program class begin
        static void Main(string[] args)
        {//Main begin
            //Process class is a built in call from System.Diagnostics namespace
            Process process = new Process();

            //Set the file name to start the Notwpad application
            process.StartInfo.FileName = "notepad.exe";

            //Start the process
            process.Start();

            //Get all the processess/treads running with the name 'notepad'
            Process[] processes = Process.GetProcessesByName("notepad");
            foreach (var proc in processes)
            {//for begin 
                //Print the process ID to the console
                Console.WriteLine($"Process ID: {proc.Id}");
            }//for end

        }//Main end
    }//process class end
}//namespace end
