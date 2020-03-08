﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace cw1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(args[0]);
            Console.WriteLine(response);
        }
    }
}
