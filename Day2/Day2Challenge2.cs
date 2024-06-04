using System.Text.RegularExpressions;
public class Day2Challenge2(){

    string path = @"E:\CSharp\Console\AdventOfCode2023\Day2\inputD2C1.txt";
    public void Run(){

        int total = 0;
        StreamReader sr = new StreamReader(path);
        string? line = sr.ReadLine();

        while(line != null){

            line = line.Substring(line.IndexOf(':')+2);

            int[] dice = new int[3];
            line = Regex.Replace(line, "[;,]", "");
            string[] sets = line.Split(' ');

            for(int i = 1; i < sets.Length;){
                switch(sets[i]){
                    case "blue":
                    if(dice[2] < Int32.Parse(sets[i-1])) dice[2] = Int32.Parse(sets[i-1]);
                    break;
                    case "green":
                    if(dice[1] < Int32.Parse(sets[i-1])) dice[1] = Int32.Parse(sets[i-1]);
                    break;
                    case "red":
                    if(dice[0] < Int32.Parse(sets[i-1])) dice[0] = Int32.Parse(sets[i-1]);
                    break;
                }
                i++;
                i++;
            }

            total += dice[0]*dice[1]*dice[2];
            line = sr.ReadLine();
        }
        Console.WriteLine("Total: " + total);
    }
}