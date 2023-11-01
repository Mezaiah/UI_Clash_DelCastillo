using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;


public class Level_Manager : MonoBehaviour
{
    public List<CR_Character> characterz;
    public void LoadCharacter(string _FileName)
    {
        string path = Application.dataPath + "/Resources/" + _FileName + ".json";
        string data = File.ReadAllText(path);
        var resource = JSON.Parse(path);

        for (int i = 0; i < resource.Count; i++)
        {
            CR_Character chara = new CR_Character();
            chara.name = resource[i]["name"].Value;
            chara.rarity = resource[i]["rarity"].Value;
            characterz.Add(chara);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        characterz = new List<CR_Character>();
        LoadCharacter("characters");
        //FileSystem.instance.LoadCharacter("characters");
        //CR_Character CharData = FileSystem.instance.LoadFromJSON<CR_Character>("characters");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
