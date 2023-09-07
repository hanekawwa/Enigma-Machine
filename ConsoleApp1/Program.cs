using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.IO;
using System.Text.RegularExpressions;
using ConsoleApp1;
using static ConsoleApp1.library;

class Rotor {
    public IDictionary<char, char> Wiring { get; set; } 
    public int Count { get; set; }
    public List<int> Turnover { get; set; }
    public int Setting { get; set; }
    public IDictionary<char, char> Reverse { get; set; }
    public bool Krieg { get; set; }
    

    public Rotor(IDictionary<char, char> Wiring, int Count, List<int> Turnover, int Setting, IDictionary<char, char> Reverse, bool Krieg) {
        this.Wiring = Wiring;
        this.Count = Count;
        this.Turnover = Turnover;
        this.Setting = Setting;
        this.Reverse = Reverse;
        this.Krieg = Krieg;

    }
    
    
}

class Program {
    static string pat = "[A-Z]-[A-Z]";
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
    
    public static Rotor Create(string Name, bool Kriegsmarine) {
        library lib = new library();
        List<int> Turn = new List<int>();
        IDictionary<char, char> Temp = new Dictionary<char, char>();
        if (Kriegsmarine) {
            Turn = lib.MasterDictKT[Name];
            Temp = lib.MasterDictK[Name];
        }
        else {
            Turn = lib.MasterDictT[Name];
            Temp = lib.MasterDict[Name];
        }

        IDictionary<char, char> TempR = Temp.ToDictionary(x => x.Value, x => x.Key);
        Console.WriteLine("Input Ring Setting (Ringstellung)(0-25)");
        int sett = Int32.Parse(Console.ReadLine());
        while (sett > 25) {
            Console.WriteLine("Maximum number for Ring Setting is 25!");
            Console.WriteLine("Input Ring Setting (Ringstellung)(0-25)");
            sett = Int32.Parse(Console.ReadLine());
        }
        Console.WriteLine("Input Ring Offset(Grundstellung)(0-25)");
        int offs = Int32.Parse(Console.ReadLine());
        while (offs > 25) {
            Console.WriteLine("Maximum number for Ring Offset is 25!");
            Console.WriteLine("Input Ring Offset(Grundstellung)(0-25)");
            offs = Int32.Parse(Console.ReadLine());
        }
        Rotor Temporary = new Rotor(Temp, offs, Turn, sett, TempR, Kriegsmarine);
        return Temporary;
    }
    
    private static IDictionary<char, char> ActiveReflector;
    
    private static List<Rotor> ROTORS;

    static void Main() {
        while (true) {
            library lib = new library();
            PLUG = new Dictionary<char, char>(){
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
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);
            Console.WriteLine("How many letters to be connected on the plugboard?(0-13)");
            int PlugboardCount = Int32.Parse(Console.ReadLine());
            while (PlugboardCount > 13) {
                Console.WriteLine("Maximum number of connections is 13!");
                Console.WriteLine("How many letters to be connected on the plugboard?(0-13)");
                PlugboardCount = Int32.Parse(Console.ReadLine());
            }
            if (PlugboardCount != 0) {
                Console.WriteLine("Input the plugboard settings (in format \"A-B\"):");
                for (int i = 0; i < PlugboardCount; i++) {
                    Console.WriteLine("Current connection: #" + (i + 1));
                    string Temporary = Console.ReadLine().ToUpper();
                    if (!r.IsMatch(Temporary)) {
                        i--;
                        Console.WriteLine("Please input in format \"A-B\" ");
                        continue;
                    }
                    
                    if (PLUG[Temporary[0]] == Temporary[0] && PLUG[Temporary[2]] == Temporary[2]) {
                        PLUG[Temporary[0]] = Temporary[2];
                        PLUG[Temporary[2]] = Temporary[0];
                    }
                    else {
                        Console.WriteLine("You already set this letter on the plugboard!");
                        i--;
                    }
                }
            }



            ROTORS = new List<Rotor>() {
        };
            int amount = 0;
            string Roman;
            do {
                Console.WriteLine("Do you want to use 3 (Default) or 4 (Kriegsmarine version) rotors?");
                amount = Int32.Parse(Console.ReadLine());
                if (amount == 3) {
                    Console.WriteLine("What reflector do you want to use (Umkehrwalze)?(Input number)");
                    int ccc = 0;
                    foreach (string j in lib.MasterDictR.Keys) {
                        ccc += 1;
                        Console.WriteLine("#" + ccc + ": " + j);
                    }
                    
                    int ReflectorInput = Int32.Parse(Console.ReadLine());
                    while (ReflectorInput > lib.ReflectorK.Count || ReflectorInput==0) {
                        Console.WriteLine("Reflector with that number does not exist!");
                        Console.WriteLine("What reflector do you want to use (Umkehrwalze)?(Input number)");
                        ccc = 0;
                        foreach (string j in lib.MasterDictR.Keys) {
                            ccc += 1;
                            Console.WriteLine("#" + ccc + ": " + j);
                        }

                        ReflectorInput = Int32.Parse(Console.ReadLine());
                    }

                    ActiveReflector = lib.Reflector[ReflectorInput - 1];
                }
                else if (amount == 4) {
                    Console.WriteLine("What thin reflector do you want to use (thin) (Umkehrwalze)?(Input number)");
                    int ccc = 0;
                    foreach (string j in lib.MasterDictKR.Keys) {
                        ccc += 1;
                        Console.WriteLine("#" + ccc + ": " + j);
                    }
                    
                    int ReflectorInput = Int32.Parse(Console.ReadLine());
                    while (ReflectorInput > lib.ReflectorK.Count||ReflectorInput==0) {
                        Console.WriteLine("Reflector with that number does not exist!");
                        Console.WriteLine("What reflector do you want to use (Umkehrwalze)?(Input number)");
                        ccc = 0;
                        foreach (string j in lib.MasterDictKR.Keys) {
                            ccc += 1;
                            Console.WriteLine("#" + ccc + ": " + j);
                        }

                        ReflectorInput = Int32.Parse(Console.ReadLine());
                    }

                    ActiveReflector = lib.ReflectorK[ReflectorInput - 1];
                }
                else {
                    Console.WriteLine("Wrong input! Please choose either 3 or 4 rotors.");
                    amount = 0;
                }
            } while (amount != 3 && amount != 4);


            for (int i = 0; i < amount; i++) {
            Rotor temp = null;
            if (i == 3) {
                Console.WriteLine("What should rotor #" + (i + 1) + " (thin) be? Choose out of the following:");
                int co = 0;
                foreach (string j in lib.MasterDictK.Keys) {
                    co += 1;
                    Console.Write("#"+co+": "+j+", ");
                }
                Roman = Console.ReadLine().ToUpper();
                if (lib.MasterDictK.ContainsKey(Roman)) {
                    temp = Create(Roman, true);
                }
                else {
                    Console.WriteLine("No such rotor exists! Please input a valid rotor.");
                    i--;
                }
                
            }
            else {
                Console.WriteLine("What should rotor #" + (i + 1) + " be? Choose out of the following:");
                int cc = 0;
                foreach (string j in lib.MasterDict.Keys) {
                    cc += 1;
                    Console.Write("#" + cc + ": " + j + ", ");
                }

                Roman = Console.ReadLine().ToUpper();
                if (lib.MasterDict.ContainsKey(Roman)) {
                    temp = Create(Roman, false);
                }
                else {
                    Console.WriteLine("No such rotor exists! Please input a valid rotor.");
                    i--;
                }
            }


            if (temp != null) {
                ROTORS.Add(temp);
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
            Regex inp = new Regex("[A-Z]", RegexOptions.IgnoreCase);
            input_data = input_data.ToUpper();
            for (int i = 0; i < input_data.Length; i++) {
                if (inp.IsMatch(input_data[i]+"")) {
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
            if (ROTORS[k].Turnover.Contains(ROTORS[k].Count)&& k!=ROTORS.Count-1 && !ROTORS[k+1].Krieg) {
                ROTORS[k + 1].Count += 1;
                if (ROTORS[k+1].Turnover.Contains(ROTORS[k+1].Count+1)&& k+1!=ROTORS.Count-1) {
                    ROTORS[k + 1].Count += 1;
                }
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

        LETT = ActiveReflector[LETT];
        for (int i = ROTORS.Count()-1; i >= 0; i--) {
            LETT = ROTORS[i].Reverse[LETT];
            LETT = Rotate(LETT, -ROTORS[i].Count,-ROTORS[i].Setting);

        }
        LETT = PLUG[LETT];

        return LETT;
    }
}