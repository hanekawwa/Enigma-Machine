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
    static IDictionary<char, char> PLUG = new Dictionary<char, char>(){
        { 'A', 'A' },
        { 'B', 'B' },
        { 'C', 'C' },
        { 'D', 'D' },
        { 'E', 'E' },
        { 'F', 'F' },
        { 'G', 'G' },
        { 'H', 'H' },
        { 'I', 'I' },
        { 'J', 'J' },
        { 'K', 'K' },
        { 'L', 'L' },
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
        { 'Z', 'Z' },
    };
    
    public static Rotor Create(string Name) {
        IDictionary<char, char> Temp = new Dictionary<char, char>() { };
        IDictionary<char, char> TempR = new Dictionary<char, char>() { };
        List<int> Turn = new List<int>() { };
        String line;
        try
        {
            StreamReader sr = new StreamReader("..\\"+Name+".txt");
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
    

    private static List<Rotor> ROTORS;

    static void Main() {
        while (true) {
        ROTORS = new List<Rotor>() {
        };
        Console.WriteLine("Do you want to use 3 (default) or 4 (kriegsmarine version) rotors?");
        int amount = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < amount; i++) {
            Console.WriteLine("What should rotor #" + (i + 1) + " be?");
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
            Console.WriteLine("Type the message");
            while ((input = Console.ReadLine()) != null) {
                input_data += input;
            }

            input_data = input_data.ToUpper();
            for (int i = 0; i < input_data.Length; i++) {
                if (char.IsLetter(input_data[i])) {
                    result += Encode(input_data[i]);
                    counter += 1;
                    if (counter % 5 == 0) {
                        result += " ";
                    }
                }
            }

            Console.WriteLine(result);
        }
    }

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
        LETT = PLUG[LETT];
        for (int i = 0; i < ROTORS.Count(); i++) {
            LETT = Rotate(LETT, ROTORS[i].Count,ROTORS[i].Setting);
            LETT = ROTORS[i].Wiring[LETT];

        }

        LETT = UKW[LETT];
        for (int i = ROTORS.Count()-1; i >= 0; i--) {
            LETT = ROTORS[i].Reverse[LETT];
            LETT = Rotate(LETT, -ROTORS[i].Count,-ROTORS[i].Setting);

        }
        LETT = PLUG[LETT];

        return LETT;
    }
}