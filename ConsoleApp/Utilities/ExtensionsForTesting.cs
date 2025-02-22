﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleApp.Utilities
{
    public static class ExtensionsForTesting
    {
        public static void Dump(this object obj)
        {
            Console.WriteLine(obj.DumpString());
        }

        public static string DumpString(this object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}
