using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] A = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        string[] B = { "+", "-", "*", "/" };
        List<string> C = new List<string>();
        string F = string.Empty;

        string x = Console.ReadLine();

        for (int i = 0; i <= x.Length-1; i++){
            string D = x.Substring(i, 1);

            if(A.Contains(D)){
                F += D;
            }
            else {
                C.Add(F);
                C.Add(D);
                F = string.Empty;
            }
        }

        if(F != string.Empty){
           C.Add(F); 
        }

        var G = C;
        int _index1;
        int _index2;
        int _index3;
        int _index4;
        double result = 0;

        do{
            _index1 = G.FindIndex(x => x == "*");
            _index2 = G.FindIndex(x => x == "/");
            _index3 = G.FindIndex(x => x == "+");
            _index4 = G.FindIndex(x => x == "-");

            if(_index1 != -1){
                result = double.Parse(G[_index1 - 1]) * double.Parse(G[_index1 + 1]);
                G.Insert(_index1, result.ToString());
                G.RemoveAt(_index1 + 1);
                G.RemoveAt(_index1 + 1);
                G.RemoveAt(_index1 - 1);
            }
            else if(_index2 != -1){
                result = double.Parse(G[_index2 - 1]) / double.Parse(G[_index2 + 1]);
                G.Insert(_index2, result.ToString());
                G.RemoveAt(_index2 + 1);
                G.RemoveAt(_index2 + 1);
                G.RemoveAt(_index2 - 1);
            }
            else if (_index3 != -1)
            {
                result = double.Parse(G[_index3 - 1]) + double.Parse(G[_index3 + 1]);
                G.Insert(_index3, result.ToString());
                G.RemoveAt(_index3 + 1);
                G.RemoveAt(_index3 + 1);
                G.RemoveAt(_index3 - 1);
            }
            else if (_index4 != -1)
            {
                result = double.Parse(G[_index4 - 1]) - double.Parse(G[_index4 + 1]);
                G.Insert(_index4, result.ToString());
                G.RemoveAt(_index4 + 1);
                G.RemoveAt(_index4 + 1);
                G.RemoveAt(_index4 - 1);
            }
        } while (_index1 != -1 || _index2 != -1 || _index3 != -1 || _index4 != -1);

        Console.WriteLine(G[0]);
    }
}

// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         List<string> sentences = new List<string> {"I love bikes", "I have boat and car", "I no have truck"};
//         List<string> excludeList = new List<string> {"bike", "boat", "car"};

//         IEnumerable<string> x = sentences.Where(sentence => !excludeList.Any(word => sentence.Contains(word)));

//         foreach (string sentence in x)
//         {
//             Console.WriteLine(sentence);
//         }
//     }
// }