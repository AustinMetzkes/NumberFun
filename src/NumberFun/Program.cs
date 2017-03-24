using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using NumberFun.Models;

namespace NumberFun
{
    public class Program
    {
        
        public static void Main(string[] args)


        {
            Console.WriteLine("hello, what is your name? ");
            var _name = Console.ReadLine();
            Console.WriteLine($"Hello {_name}");
            Console.WriteLine("enter a number");
            var Number = Console.ReadLine();
            Console.WriteLine("Number test");
            TestNumber();
            

            var host = new WebHostBuilder()
                    .UseKestrel()                
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();

            host.Run();

        }
        static void TestNumber()
        {
            NumericProperties n = new NumericProperties(7);
        }
        //public static async Task HandleRequest(HttpContext context)

        //  await context.Respone.WriteAsync($"Hello{_name}");
    }
}