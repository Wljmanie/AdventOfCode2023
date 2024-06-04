public class Day2Challenge1(){
    
    string path = @"E:\CSharp\Console\AdventOfCode2023\Day2\inputD2C1.txt";

    public void Run(){
        int total = 0;
        StreamReader sr = new StreamReader(path);


        string? line = sr.ReadLine();
       // VerifyGame(line);

        while(line != null){
            total += VerifyGame(line);
            line = sr.ReadLine();
        }
        Console.WriteLine("Total: " + total);
        sr.Close();
    }

    public int VerifyGame(string line){
        string[] Game = line.Split(';',':',',');
        Game[0] = Game[0].Substring(5);
        string[] set;
        for(int i = 1; i < Game.Length; i++){
            set = Game[i].Split(' ');
            
            if(VerifySet(set) == false) return 0;
        }
        return Int32.Parse(Game[0]);
    }

    public bool VerifySet(string[] set){
        if(set[2] == "green" && Int32.Parse(set[1]) > 13) return false;
        if(set[2] == "red" && Int32.Parse(set[1]) > 12) return false;
        if(set[2] == "blue" && Int32.Parse(set[1]) > 14) return false;
        return true;
    }
}