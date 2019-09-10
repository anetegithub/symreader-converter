using Microsoft.DiaSymReader;
using Microsoft.DiaSymReader.Tools;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace PdbEdit
{
    class Program
    {
        static void Main(string[] args)
        {
            var exePath = "";

            using (var peStream = new FileStream(exePath, FileMode.Open, FileAccess.Read))
            using (var peReader = new PEReader(peStream, PEStreamOptions.LeaveOpen))
            {

            }
        }
    }
}
