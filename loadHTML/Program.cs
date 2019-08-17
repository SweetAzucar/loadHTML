using System;
using System.Collections;
using System.IO;

namespace loadHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            HTML hola = new HTML();
            hola.LoadFile("index.html");
        }
    }
}
