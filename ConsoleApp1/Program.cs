using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.IO;

class Rotor {
    public IDictionary<char, char> Wiring { get; set; } 
    public int Count { get; set; }
    public List<int> Turnover { get; set; }
    public int Setting { get; set; }
    public IDictionary<char, char> Reverse { get; set; }

    public Rotor(IDictionary<char, char> Wiring, int Count, List<int> Turnover, int Setting, IDictionary<char, char> Reverse) {
        this.Wiring = Wiring;
        this.Count = Count;
        this.Turnover = Turnover;
        this.Setting = Setting;
        this.Reverse = Reverse;

    }
    
    
}

class Program {
    
    public static Rotor Create(string Name) {
        IDictionary<char, char> Temp = new Dictionary<char, char>() { };
        IDictionary<char, char> TempR = new Dictionary<char, char>() { };
        List<int> Turn = new List<int>() { };
        String line;
        try
        {
            StreamReader sr = new StreamReader("C:\\Users\\Nikita\\RiderProjects\\Solution2\\ConsoleApp1\\"+Name+".txt");
            for (int i = 0; i < 26; i++) {
                line = sr.ReadLine();
                Temp.Add(line[0], line[2]);
                TempR.Add(line[2], line[0]);
            }
            line = sr.ReadLine();
            line = sr.ReadLine();
            string[]line1 = line.Split(',');
            foreach(string i in line1)  {
                int v = Int32.Parse(i);
                Turn.Add(v);
            }
            sr.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
            return null;
        }
        Console.WriteLine("Input Ring Setting (Ringstellung)");
        int sett = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Input Ring Offset");
        int offs = Int32.Parse(Console.ReadLine());

        Rotor Temporary = new Rotor(Temp, offs, Turn, sett, TempR);
        return Temporary;
    }

    private static List<int> COUNT = new List<int>() {
        3, 5, 6
    };
    private static List<int> SETTING = new List<int>() {
        5, 5, 5
    };
    static IDictionary<char, char> I = new Dictionary<char, char>(){
            { 'A', 'J' },
            { 'B', 'G' },
            { 'C', 'D' },
            { 'D', 'Q' },
            { 'E', 'O' },
            { 'F', 'X' },
            { 'G', 'U' },
            { 'H', 'S' },
            { 'I', 'C' },
            { 'J', 'A' },
            { 'K', 'M' },
            { 'L', 'I' },
            { 'M', 'F' },
            { 'N', 'R' },
            { 'O', 'V' },
            { 'P', 'T' },
            { 'Q', 'P' },
            { 'R', 'N' },
            { 'S', 'E' },
            { 'T', 'W' },
            { 'U', 'K' },
            { 'V', 'B' },
            { 'W', 'L' },
            { 'X', 'Y' },
            { 'Y', 'Z' },
            { 'Z', 'H' },
        };
    static IDictionary<char, char> II = new Dictionary<char, char>(){
            { 'A', 'N' },
            { 'B', 'T' },
            { 'C', 'Z' },
            { 'D', 'P' },
            { 'E', 'S' },
            { 'F', 'F' },
            { 'G', 'B' },
            { 'H', 'O' },
            { 'I', 'K' },
            { 'J', 'M' },
            { 'K', 'W' },
            { 'L', 'R' },
            { 'M', 'C' },
            { 'N', 'J' },
            { 'O', 'D' },
            { 'P', 'I' },
            { 'Q', 'V' },
            { 'R', 'L' },
            { 'S', 'A' },
            { 'T', 'E' },
            { 'U', 'Y' },
            { 'V', 'U' },
            { 'W', 'X' },
            { 'X', 'H' },
            { 'Y', 'G' },
            { 'Z', 'Q' },
        };
    static IDictionary<char, char> III = new Dictionary<char, char>(){
            { 'A', 'J' },
            { 'B', 'V' },
            { 'C', 'I' },
            { 'D', 'U' },
            { 'E', 'B' },
            { 'F', 'H' },
            { 'G', 'Y' },
            { 'H', 'C' },
            { 'I', 'D' },
            { 'J', 'Y' },
            { 'K', 'A' },
            { 'L', 'K' },
            { 'M', 'E' },
            { 'N', 'Q' },
            { 'O', 'Z' },
            { 'P', 'P' },
            { 'Q', 'O' },
            { 'R', 'S' },
            { 'S', 'G' },
            { 'T', 'X' },
            { 'U', 'N' },
            { 'V', 'R' },
            { 'W', 'M' },
            { 'X', 'W' },
            { 'Y', 'F' },
            { 'Z', 'L' },
        };
    static IDictionary<char, char> IR = new Dictionary<char, char>(){
            { 'J', 'A' },
            { 'G', 'B' },
            { 'D', 'C' },
            { 'Q', 'D' },
            { 'O', 'E' },
            { 'X', 'F' },
            { 'U', 'G' },
            { 'S', 'H' },
            { 'C', 'I' },
            { 'A', 'J' },
            { 'M', 'K' },
            { 'I', 'L' },
            { 'F', 'M' },
            { 'R', 'N' },
            { 'V', 'O' },
            { 'T', 'P' },
            { 'P', 'Q' },
            { 'N', 'R' },
            { 'E', 'S' },
            { 'W', 'T' },
            { 'K', 'U' },
            { 'B', 'V' },
            { 'L', 'W' },
            { 'Y', 'X' },
            { 'Z', 'Y' },
            { 'H', 'Z' },
        };
    static IDictionary<char, char> IIR = new Dictionary<char, char>(){
            { 'N', 'A' },
            { 'T', 'B' },
            { 'Z', 'C' },
            { 'P', 'D' },
            { 'S', 'E' },
            { 'F', 'F' },
            { 'B', 'G' },
            { 'O', 'H' },
            { 'K', 'I' },
            { 'M', 'J' },
            { 'W', 'K' },
            { 'R', 'L' },
            { 'C', 'M' },
            { 'J', 'N' },
            { 'D', 'O' },
            { 'I', 'P' },
            { 'V', 'Q' },
            { 'L', 'R' },
            { 'A', 'S' },
            { 'E', 'T' },
            { 'Y', 'U' },
            { 'U', 'V' },
            { 'X', 'W' },
            { 'H', 'X' },
            { 'G', 'Y' },
            { 'Q', 'Z' },
        };
    static IDictionary<char, char> IIIR = new Dictionary<char, char>(){
            { 'J', 'A' },
            { 'V', 'B' },
            { 'I', 'C' },
            { 'U', 'D' },
            { 'B', 'E' },
            { 'H', 'F' },
            { 'T', 'G' },
            { 'C', 'H' },
            { 'D', 'I' },
            { 'Y', 'J' },
            { 'A', 'K' },
            { 'K', 'L' },
            { 'E', 'M' },
            { 'Q', 'N' },
            { 'Z', 'O' },
            { 'P', 'P' },
            { 'O', 'Q' },
            { 'S', 'R' },
            { 'G', 'S' },
            { 'X', 'T' },
            { 'N', 'U' },
            { 'R', 'V' },
            { 'M', 'W' },
            { 'W', 'X' },
            { 'F', 'Y' },
            { 'L', 'Z' },
        };
    static IDictionary<char, char> UKW = new Dictionary<char, char>(){
            { 'A', 'Q' },
            { 'B', 'Y' },
            { 'C', 'H' },
            { 'D', 'O' },
            { 'E', 'G' },
            { 'F', 'N' },
            { 'G', 'E' },
            { 'H', 'C' },
            { 'I', 'V' },
            { 'J', 'P' },
            { 'K', 'U' },
            { 'L', 'Z' },
            { 'M', 'T' },
            { 'N', 'F' },
            { 'O', 'D' },
            { 'P', 'J' },
            { 'Q', 'A' },
            { 'R', 'X' },
            { 'S', 'W' },
            { 'T', 'M' },
            { 'U', 'K' },
            { 'V', 'I' },
            { 'W', 'S' },
            { 'X', 'R' },
            { 'Y', 'B' },
            { 'Z', 'L' },
        };
    static IDictionary<char, char> PLUG = new Dictionary<char, char>(){
            { 'A', 'B' },
            { 'B', 'A' },
            { 'C', 'Z' },
            { 'D', 'D' },
            { 'E', 'L' },
            { 'F', 'F' },
            { 'G', 'G' },
            { 'H', 'H' },
            { 'I', 'I' },
            { 'J', 'J' },
            { 'K', 'K' },
            { 'L', 'E' },
            { 'M', 'M' },
            { 'N', 'N' },
            { 'O', 'O' },
            { 'P', 'P' },
            { 'Q', 'Q' },
            { 'R', 'R' },
            { 'S', 'S' },
            { 'T', 'T' },
            { 'U', 'U' },
            { 'V', 'V' },
            { 'W', 'W' },
            { 'X', 'X' },
            { 'Y', 'Y' },
            { 'Z', 'C' },
        };

    private static List<Rotor> ROTORS = new List<Rotor>() {
    };

    static void Main() {
        Console.WriteLine("Do you want to use 3 (default) or 4 (kriegsmarine version) rotors?");
        int amount = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < amount; i++) {
            Console.WriteLine("What should rotor №"+i+1+"be?");
            string Roman = Console.ReadLine();
            Rotor temp = Create(Roman);
            if (temp != null) {
                ROTORS.Add(temp);
            }
            else {
                i--;
            }
        }
        string input;
        string input_data = "";
        string result = "";
        int counter = 0;
        while ((input = Console.ReadLine()) != null) {
            input_data += input;
        }
        input_data = input_data.ToUpper();
        for (int i = 0; i < input_data.Length; i++) {
            if(char.IsLetter(input_data[i])) {
                result += Encode(input_data[i]);
                counter += 1;
                if (counter % 5 == 0) {
                    result += " ";
                }
            }
        }
        Console.WriteLine(result);}
    public static char Rotate(char ch, int n, int z)
    {
        if (ch >= 'A' && ch <= 'Z')
        {
            return (char)(((ch - 'A' + n + 26 - z) % 26) + 'A');
        }
        return ch;
    }
    static char Encode(char LETT) {
        int k = 0;
        ROTORS[k].Count += 1;
        while (k < ROTORS.Count) {
            if (ROTORS[k].Turnover.Contains(ROTORS[k].Count)&& k!=ROTORS.Count-1) {
                ROTORS[k + 1].Count += 1;
            }

            if (ROTORS[k].Count > 25) {
                ROTORS[k].Count = 0;
            }

            k += 1;
        }
        Console.WriteLine(LETT);
        LETT = PLUG[LETT];
        Console.WriteLine(LETT);
        for (int i = 0; i < ROTORS.Count(); i++) {
            LETT = Rotate(LETT, ROTORS[i].Count,ROTORS[i].Setting);
            LETT = ROTORS[i].Wiring[LETT];
            Console.WriteLine(LETT);

        }

        LETT = UKW[LETT];
        Console.WriteLine(LETT);
        for (int i = ROTORS.Count()-1; i >= 0; i--) {
            LETT = ROTORS[i].Reverse[LETT];
            LETT = Rotate(LETT, -ROTORS[i].Count,-ROTORS[i].Setting);
            Console.WriteLine(LETT);

        }
        LETT = PLUG[LETT];


        // COUNT[0] = COUNT[0] + 1;
        // if (COUNT[0] > 25) {
        //     COUNT[1] += 1;
        //     COUNT[0] = 0;
        //     if (COUNT[1] > 25) {
        //         COUNT[2] += 1;
        //         COUNT[1] = 0;
        //         if (COUNT[2] > 25) {
        //             COUNT[2] = 0;
        //         }
        //     }
        // }
        return LETT;
    }
}