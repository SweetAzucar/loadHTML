using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace loadHTML
{
    class HTML
    {
        // private string Tag {get; set;}

        // private string Attribute {get; set;}

        // private Hashtable Elements {get; set;}

        public void LoadFile(string filePath)
        {
            
            List<string> result = new List<string>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string htmlElmnt = "";
                bool tagStart = false;

                foreach (char c in line.ToString())
                {
                    int nextChar = 0;
                    nextChar += 1;
                    

                    if (c == '<')
                    {
                        tagStart = true;
                        continue; // Saltea el inicio del tag
                    } 

                    if (c == '/')
                    {
                        tagStart = false;
                        continue;
                    }




                    if (tagStart && c != '>' && c != ' ') //comienza mi escritura del elemento HTML hasta que cierre el tag
                    {
                        htmlElmnt += c;
                    }

                }

                string[] splittedElmnt = htmlElmnt.Split(" "); // separo los distintos atributos en un tag
                
                foreach (var el in splittedElmnt)
                {
                    result.Add(el); //para cada tag y atributo, los voy agregando a result
                }
                
    
            }
        
            foreach (var el in result)
            {
                Console.WriteLine(el);  
            }
        }
    }    
}
