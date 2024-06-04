using System.Text;
using System.Text.RegularExpressions;

public class Day1Challange2(){
     
    string path = @"E:\CSharp\Console\AdventOfCode2023\Day1\inputD1C2.txt";

    StringBuilder sb = new StringBuilder();
    public void Run(){

        int total = 0;

        StreamReader sr = new StreamReader(path);
        string? line = sr.ReadLine();

        while(line != null){
            line = CleanString(line);
            Console.WriteLine(line);
            total += Int32.Parse(line);
            line = sr.ReadLine();
        }
        
        sr.Close();
        Console.WriteLine("Total: " + total);

    }

    public string CleanString(string line){

        sb.Clear();
        StringBuilder chars = new StringBuilder(line);

        


        
        for(int i = 0; i < chars.Length; i++){

            if(Regex.IsMatch(chars[i].ToString(), "[0-9]")){
                sb.Append(chars[i]);

            }
            else if(!Regex.IsMatch(chars[i].ToString(), "[otfsen]")){
                continue;
            }

            if(chars.Length >= i + 3){
                if(chars.ToString(i,3) == "one") sb.Append('1');
                else if (chars.ToString(i,3) == "two") sb.Append('2');
                else if (chars.ToString(i,3) == "six") sb.Append('6');

            }
            if(chars.Length >= i + 4){
                if (chars.ToString(i,4) == "four") sb.Append('4');
                else if (chars.ToString(i,4) == "five") sb.Append('5');
                else if (chars.ToString(i,4) == "nine") sb.Append('9');

            }
            if(chars.Length >= i +5){
                if (chars.ToString(i,5) == "three") sb.Append('3');
                else if (chars.ToString(i,5) == "seven") sb.Append('7');
                else if (chars.ToString(i,5) == "eight") sb.Append('8');

            }
            
        }


        StringBuilder result = new StringBuilder();
        result.Append(sb[0]);
        result.Append(sb[sb.Length-1]);
        return result.ToString();
    }
}