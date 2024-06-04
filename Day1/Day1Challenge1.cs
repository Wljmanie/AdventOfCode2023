using System.Text;
using System.Text.RegularExpressions;

public class Day1Challenge1 (){

    string path = @"E:\CSharp\Console\AdventOfCode2023\Day1\inputD1C1.txt";

    public void Run(){
        if(File.Exists(path))
            Console.WriteLine("It exists.");
            
        int total = 0;
        
        StreamReader sr = new StreamReader(path);
        StringBuilder sb = new StringBuilder();
        string? line = sr.ReadLine();
        while(line != null){
            line = Regex.Replace(line, @"[^0-9]", "" );
            if(line.Length == 1){
                line += line;
            }
            sb.Append(line.First());
            sb.Append(line.Last());
            total += Int32.Parse(sb.ToString());
            sb.Clear();
            line = sr.ReadLine();
        }
        
        sr.Close();
        Console.WriteLine("Total: " + total);
    }
}  