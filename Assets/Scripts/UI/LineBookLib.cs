using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBookLib : MonoBehaviour
{
    Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

    public List<string> cafe_1and2 = new List<string>();
    public List<string> office_Colleague = new List<string>();



    public void Init()
    {
        dic.Add("cafe_1and2", cafe_1and2);
        dic.Add("office_Colleague", office_Colleague);


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
