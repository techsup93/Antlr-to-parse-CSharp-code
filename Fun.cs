using System;
using System.Collections.Generic;
using System.Text;
using Antlr4;
using Antlr4.Runtime;


namespace AntlrExample
{
    class Fun
    {

        public static String output = "";
        private static int labelcount = 0, tempcounter = 0;
       private static Stack<string> CompilerStack = new Stack<string>();

        public static void PushToken(IToken V)
        {         
            String S = V.Text;
            PushToken(S);
        }
        public static void PushToken(String V)
        {
            CompilerStack.Push(V);
        }

        public static String PopTV()
        {
            String s = CompilerStack.Pop().ToString();
            return s;
        }

        public static String getTemp()
        {
            return "$T" + (tempcounter++);
        }

        public static void removeTemp()
        {
            tempcounter--;
        }

        public static Boolean isTemp(String variable)
        {
            return variable.StartsWith("$T");
        }

        public static String getLabel()
        {
            return "$L" + (labelcount++);
        }


        public static void emitln(String s)
        {
            output += s + "\n";
            
        }


    }
}
