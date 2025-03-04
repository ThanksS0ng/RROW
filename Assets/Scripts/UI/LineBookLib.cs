using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBookLib : MonoBehaviour
{
    Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

    public List<string> Cafe_1and2 = new List<string>();




    public void Init()
    {
        dic.Add("Cafe_1and2", Cafe_1and2);


    }

    public List<string> GetLineBook(string bookName)
    {
        if (dic.ContainsKey(bookName))
            return dic[bookName];
        else
        {
            print("Not find anyh book.");
            return null;
        }

    }
}
