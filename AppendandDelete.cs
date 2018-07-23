using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the appendAndDelete function below.
    static string appendAndDelete(string s, string t, int k) {
        char[] ss = s.ToCharArray();
        char[] tt = t.ToCharArray();
        int i;
        for( i=0; i < Math.Min(tt.Length ,ss.Length); i++)
        {
            if(ss[i] != tt[i])
                break;
        }
        int sDif,tDif;
        sDif = ss.Length - i;
        tDif = tt.Length -i;
        if(sDif + tDif > k)
        {
            return "No";
        }
        else if((sDif + tDif)%2 == k%2 || ss.Length + tt.Length <=k)
        {
            return "Yes";
        }        
            return "No";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
