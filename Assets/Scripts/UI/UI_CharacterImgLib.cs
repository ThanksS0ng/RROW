using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CharacterImgLib : MonoBehaviour
{
    public List<Sprite> list_CharacterImgs = new List<Sprite>();

    public void Init()
    {
        
    }

    public Sprite GetCharacterImg(string name)
    {
        foreach (var item in list_CharacterImgs)
        {
            if (item.name == name)
            {
                return item;
            }
        }
        print("No Character Image.");
        return null;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
