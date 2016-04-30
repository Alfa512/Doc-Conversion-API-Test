using System;

namespace CSharp.Api.Client.Web
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _sdk = new SDKTest();
            var command = "";
            while (command.ToLower().Trim() != "exit")
            {
                command = _sdk.Start();
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}