﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1_Parser.Model
{
	[Serializable]
	public class Token
    {
        string content;
        bool terminal; // Bandera para indicar si es terminal o no-terminal
        string val; // Guarda lexema o el resultado de evaluar un conjunto de atributos

        //Getters and Setters
        public string Content { get { return content; } set { content = value; } }
        public bool IsTerminal { get { return terminal; } set { terminal = value; } }
        public string Val { get { return val; } set { val = value; } }
      

        public Token(string s, bool t)
        {
            terminal = t;
            content = s;
        }
        public Token()
        { }

        public Token(string s, bool t, string v)
        {
            terminal = t;
            content = s;
            val = v;
        }

        public override string ToString()
        {
            return content;
        }

      
    }
}
