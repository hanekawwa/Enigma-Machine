﻿using System.Collections.Generic;
namespace ConsoleApp1; 

public class library {
    public Dictionary<string, IDictionary<char,char>> MasterDictR = new Dictionary<string, IDictionary<char,char>>
    {
        { "UKW-B", UKW_B},
        { "UKW-C", UKW_C},
    };
    public Dictionary<string, IDictionary<char,char>> MasterDictKR = new Dictionary<string, IDictionary<char,char>>
    {
        { "UKW-B Thin", UKW_BT},
        { "UKW-C Thin", UKW_CT},
    };
    public List<IDictionary<char, char>> Reflector = new List<IDictionary<char, char>>() {UKW_B,UKW_C};
    public List<IDictionary<char, char>> ReflectorK = new List<IDictionary<char, char>>() {UKW_BT,UKW_CT};
    public Dictionary<string, List<int>> MasterDictT = new Dictionary<string, List<int>>
    {
        { "I", IT},
        { "II", IIT},
        { "III", IIIT},
        { "IV", IVT},
        { "V", VT},
        { "VI", VIT},
        { "VII", VIIT},
        { "VIII", VIIIT},
    };
    
    public Dictionary<string, IDictionary<char,char>> MasterDict = new Dictionary<string, IDictionary<char,char>>
    {
        { "I", I},
        { "II", II},
        { "III", III},
        { "IV", IV},
        { "V", V},
        { "VI", VI},
        { "VII", VII},
        { "VIII", VIII},
    };
    
    public Dictionary<string, List<int>> MasterDictKT = new Dictionary<string, List<int>>
    {
        { "BETA", BETAT},
        { "GAMMA", GAMMAT},
    };
    
    public Dictionary<string, IDictionary<char,char>> MasterDictK = new Dictionary<string, IDictionary<char,char>>
    {
        { "BETA", BETA},
        { "GAMMA", GAMMA},
    };
    public static IDictionary<char, char> UKW_B = new Dictionary<char, char>(){
        { 'A', 'Y' },
        { 'B', 'R' },
        { 'C', 'U' },
        { 'D', 'H' },
        { 'E', 'Q' },
        { 'F', 'S' },
        { 'G', 'G' },
        { 'H', 'D' },
        { 'I', 'P' },
        { 'J', 'X' },
        { 'K', 'N' },
        { 'L', 'G' },
        { 'M', 'O' },
        { 'N', 'K' },
        { 'O', 'M' },
        { 'P', 'I' },
        { 'Q', 'E' },
        { 'R', 'B' },
        { 'S', 'F' },
        { 'T', 'Z' },
        { 'U', 'C' },
        { 'V', 'W' },
        { 'W', 'V' },
        { 'X', 'J' },
        { 'Y', 'A' },
        { 'Z', 'T' },
    };
    public static IDictionary<char, char> UKW_C = new Dictionary<char, char>(){
        { 'A', 'F' },
        { 'B', 'V' },
        { 'C', 'P' },
        { 'D', 'J' },
        { 'E', 'I' },
        { 'F', 'A' },
        { 'G', 'O' },
        { 'H', 'Y' },
        { 'I', 'E' },
        { 'J', 'D' },
        { 'K', 'R' },
        { 'L', 'Z' },
        { 'M', 'X' },
        { 'N', 'W' },
        { 'O', 'G' },
        { 'P', 'C' },
        { 'Q', 'T' },
        { 'R', 'K' },
        { 'S', 'U' },
        { 'T', 'Q' },
        { 'U', 'S' },
        { 'V', 'B' },
        { 'W', 'N' },
        { 'X', 'M' },
        { 'Y', 'H' },
        { 'Z', 'L' },
    };
    public static IDictionary<char, char> UKW_BT = new Dictionary<char, char>(){
        { 'A', 'E' },
        { 'B', 'N' },
        { 'C', 'K' },
        { 'D', 'Q' },
        { 'E', 'A' },
        { 'F', 'U' },
        { 'G', 'Y' },
        { 'H', 'W' },
        { 'I', 'J' },
        { 'J', 'I' },
        { 'K', 'C' },
        { 'L', 'O' },
        { 'M', 'P' },
        { 'N', 'B' },
        { 'O', 'L' },
        { 'P', 'M' },
        { 'Q', 'D' },
        { 'R', 'X' },
        { 'S', 'Z' },
        { 'T', 'V' },
        { 'U', 'F' },
        { 'V', 'T' },
        { 'W', 'H' },
        { 'X', 'R' },
        { 'Y', 'G' },
        { 'Z', 'S' },
    };
    public static IDictionary<char, char> UKW_CT = new Dictionary<char, char>(){
        { 'A', 'R' },
        { 'B', 'D' },
        { 'C', 'O' },
        { 'D', 'B' },
        { 'E', 'J' },
        { 'F', 'N' },
        { 'G', 'T' },
        { 'H', 'K' },
        { 'I', 'V' },
        { 'J', 'E' },
        { 'K', 'H' },
        { 'L', 'M' },
        { 'M', 'L' },
        { 'N', 'F' },
        { 'O', 'C' },
        { 'P', 'W' },
        { 'Q', 'Z' },
        { 'R', 'A' },
        { 'S', 'X' },
        { 'T', 'G' },
        { 'U', 'Y' },
        { 'V', 'I' },
        { 'W', 'P' },
        { 'X', 'S' },
        { 'Y', 'Y' },
        { 'Z', 'Q' },
    };
    public static IDictionary<char, char> I = new Dictionary<char, char>(){
        { 'A', 'E' },
        { 'B', 'K' },
        { 'C', 'M' },
        { 'D', 'F' },
        { 'E', 'L' },
        { 'F', 'G' },
        { 'G', 'D' },
        { 'H', 'Q' },
        { 'I', 'V' },
        { 'J', 'Z' },
        { 'K', 'N' },
        { 'L', 'T' },
        { 'M', 'O' },
        { 'N', 'W' },
        { 'O', 'Y' },
        { 'P', 'H' },
        { 'Q', 'X' },
        { 'R', 'U' },
        { 'S', 'S' },
        { 'T', 'P' },
        { 'U', 'A' },
        { 'V', 'I' },
        { 'W', 'B' },
        { 'X', 'R' },
        { 'Y', 'C' },
        { 'Z', 'J' },
    };

    static List<int> IT = new List<int>() {19};
    public static IDictionary<char, char> II = new Dictionary<char, char>(){
        { 'A', 'A' },
        { 'B', 'J' },
        { 'C', 'D' },
        { 'D', 'K' },
        { 'E', 'S' },
        { 'F', 'I' },
        { 'G', 'R' },
        { 'H', 'U' },
        { 'I', 'X' },
        { 'J', 'B' },
        { 'K', 'L' },
        { 'L', 'H' },
        { 'M', 'W' },
        { 'N', 'T' },
        { 'O', 'M' },
        { 'P', 'C' },
        { 'Q', 'Q' },
        { 'R', 'G' },
        { 'S', 'Z' },
        { 'T', 'N' },
        { 'U', 'P' },
        { 'V', 'Y' },
        { 'W', 'F' },
        { 'X', 'V' },
        { 'Y', 'O' },
        { 'Z', 'E' },
    };

    static List<int> IIT = new List<int>() {7};
    public static IDictionary<char, char> III = new Dictionary<char, char>(){
        { 'A', 'B' },
        { 'B', 'D' },
        { 'C', 'F' },
        { 'D', 'H' },
        { 'E', 'J' },
        { 'F', 'L' },
        { 'G', 'C' },
        { 'H', 'P' },
        { 'I', 'R' },
        { 'J', 'T' },
        { 'K', 'X' },
        { 'L', 'V' },
        { 'M', 'Z' },
        { 'N', 'N' },
        { 'O', 'Y' },
        { 'P', 'E' },
        { 'Q', 'I' },
        { 'R', 'W' },
        { 'S', 'G' },
        { 'T', 'A' },
        { 'U', 'K' },
        { 'V', 'M' },
        { 'W', 'U' },
        { 'X', 'S' },
        { 'Y', 'Q' },
        { 'Z', 'O' },
    };
    static List<int> IIIT = new List<int>(){24};
    public static IDictionary<char, char> IV = new Dictionary<char, char>(){
        { 'A', 'E' },
        { 'B', 'S' },
        { 'C', 'O' },
        { 'D', 'V' },
        { 'E', 'P' },
        { 'F', 'Z' },
        { 'G', 'J' },
        { 'H', 'A' },
        { 'I', 'Y' },
        { 'J', 'Q' },
        { 'K', 'U' },
        { 'L', 'I' },
        { 'M', 'R' },
        { 'N', 'H' },
        { 'O', 'X' },
        { 'P', 'L' },
        { 'Q', 'N' },
        { 'R', 'F' },
        { 'S', 'T' },
        { 'T', 'G' },
        { 'U', 'K' },
        { 'V', 'D' },
        { 'W', 'C' },
        { 'X', 'M' },
        { 'Y', 'W' },
        { 'Z', 'B' },
    };
    static List<int> IVT = new List<int>(){12};
    
    public static IDictionary<char, char> V = new Dictionary<char, char>(){
        { 'A', 'V' },
        { 'B', 'Z' },
        { 'C', 'B' },
        { 'D', 'R' },
        { 'E', 'G' },
        { 'F', 'I' },
        { 'G', 'T' },
        { 'H', 'Y' },
        { 'I', 'U' },
        { 'J', 'P' },
        { 'K', 'S' },
        { 'L', 'D' },
        { 'M', 'N' },
        { 'N', 'H' },
        { 'O', 'L' },
        { 'P', 'X' },
        { 'Q', 'A' },
        { 'R', 'W' },
        { 'S', 'M' },
        { 'T', 'J' },
        { 'U', 'Q' },
        { 'V', 'O' },
        { 'W', 'F' },
        { 'X', 'E' },
        { 'Y', 'C' },
        { 'Z', 'K' },
    };
    static List<int> VT = new List<int>(){2};
    
    public static IDictionary<char, char> VI = new Dictionary<char, char>(){
        { 'A', 'J' },
        { 'B', 'P' },
        { 'C', 'G' },
        { 'D', 'V' },
        { 'E', 'O' },
        { 'F', 'U' },
        { 'G', 'M' },
        { 'H', 'F' },
        { 'I', 'Y' },
        { 'J', 'Q' },
        { 'K', 'B' },
        { 'L', 'E' },
        { 'M', 'N' },
        { 'N', 'H' },
        { 'O', 'Z' },
        { 'P', 'R' },
        { 'Q', 'D' },
        { 'R', 'K' },
        { 'S', 'A' },
        { 'T', 'S' },
        { 'U', 'X' },
        { 'V', 'L' },
        { 'W', 'I' },
        { 'X', 'C' },
        { 'Y', 'T' },
        { 'Z', 'W' },
    };
    static List<int> VIT = new List<int>(){2,15};
    
    public static IDictionary<char, char> VII = new Dictionary<char, char>(){
        { 'A', 'N' },
        { 'B', 'Z' },
        { 'C', 'J' },
        { 'D', 'H' },
        { 'E', 'G' },
        { 'F', 'R' },
        { 'G', 'C' },
        { 'H', 'X' },
        { 'I', 'M' },
        { 'J', 'Y' },
        { 'K', 'S' },
        { 'L', 'W' },
        { 'M', 'B' },
        { 'N', 'O' },
        { 'O', 'U' },
        { 'P', 'F' },
        { 'Q', 'A' },
        { 'R', 'I' },
        { 'S', 'V' },
        { 'T', 'L' },
        { 'U', 'P' },
        { 'V', 'E' },
        { 'W', 'K' },
        { 'X', 'Q' },
        { 'Y', 'D' },
        { 'Z', 'T' },
    };
    static List<int> VIIT = new List<int>(){2,15};
    
    public static IDictionary<char, char> VIII = new Dictionary<char, char>(){
        { 'A', 'F' },
        { 'B', 'K' },
        { 'C', 'Q' },
        { 'D', 'H' },
        { 'E', 'T' },
        { 'F', 'L' },
        { 'G', 'X' },
        { 'H', 'O' },
        { 'I', 'C' },
        { 'J', 'B' },
        { 'K', 'J' },
        { 'L', 'S' },
        { 'M', 'P' },
        { 'N', 'D' },
        { 'O', 'Z' },
        { 'P', 'R' },
        { 'Q', 'A' },
        { 'R', 'M' },
        { 'S', 'E' },
        { 'T', 'W' },
        { 'U', 'N' },
        { 'V', 'I' },
        { 'W', 'U' },
        { 'X', 'Y' },
        { 'Y', 'G' },
        { 'Z', 'V' },
    };
    static List<int> VIIIT = new List<int>(){2,15};
    
    public static IDictionary<char, char> BETA = new Dictionary<char, char>(){
        { 'A', 'L' },
        { 'B', 'E' },
        { 'C', 'Y' },
        { 'D', 'J' },
        { 'E', 'V' },
        { 'F', 'C' },
        { 'G', 'N' },
        { 'H', 'I' },
        { 'I', 'X' },
        { 'J', 'W' },
        { 'K', 'P' },
        { 'L', 'B' },
        { 'M', 'Q' },
        { 'N', 'M' },
        { 'O', 'D' },
        { 'P', 'R' },
        { 'Q', 'T' },
        { 'R', 'A' },
        { 'S', 'K' },
        { 'T', 'Z' },
        { 'U', 'G' },
        { 'V', 'F' },
        { 'W', 'U' },
        { 'X', 'H' },
        { 'Y', 'O' },
        { 'Z', 'S' },
    };
    static List<int> BETAT = new List<int>(){};
    
    public static IDictionary<char, char> GAMMA = new Dictionary<char, char>(){
        { 'A', 'F' },
        { 'B', 'S' },
        { 'C', 'O' },
        { 'D', 'K' },
        { 'E', 'A' },
        { 'F', 'N' },
        { 'G', 'U' },
        { 'H', 'E' },
        { 'I', 'R' },
        { 'J', 'H' },
        { 'K', 'M' },
        { 'L', 'B' },
        { 'M', 'T' },
        { 'N', 'I' },
        { 'O', 'Y' },
        { 'P', 'C' },
        { 'Q', 'W' },
        { 'R', 'L' },
        { 'S', 'Q' },
        { 'T', 'P' },
        { 'U', 'Z' },
        { 'V', 'X' },
        { 'W', 'V' },
        { 'X', 'G' },
        { 'Y', 'J' },
        { 'Z', 'D' },
    };
    static List<int> GAMMAT = new List<int>(){};
    
}