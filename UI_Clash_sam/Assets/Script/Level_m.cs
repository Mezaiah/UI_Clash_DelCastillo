using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using SimpleJSON;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class Level_M : MonoBehaviour
{
    public List<CR_Character> characterz;
    public GameObject[] characters;

    public void LoadCharacter(string _FileName)
    {
        string path = Application.dataPath + "/Resources/" + _FileName + ".json";
        string data = File.ReadAllText(path);
        var resource = JSON.Parse(data);

        for (int i = 0; i < resource.Count; i++)
        {
            CR_Character chara = new CR_Character();
            chara.name = resource[i]["name"].Value;
            chara.rarity = resource[i]["rarity"].Value;
            chara.id = int.Parse(resource[i]["id"].Value);
            characterz.Add(chara);
        }
    }

    void Start()
    {
        characterz = new List<CR_Character>();
        LoadCharacter("characters");

        for (int i = 0; i < characters.Length; i++)
        {
            if (i < characterz.Count)
            {
                characters[i].transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[i].name;
                characters[i].transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[i].id.ToString();
           if (characterz[i].name == "Golemite" ||
                    characterz[i].name == "TowerPrincess" || 
                    characterz[i].name == "LavaPups" || 
                    characterz[i].name == "RageBarbarian" ||
                    characterz[i].name == "AngryBarbarian"||
                    characterz[i].name == "Assassin"||
                    characterz[i].name == "GhostOverlay" ||
                    characterz[i].name == "MiniZapMachine" ||
                    characterz[i].name == "BrokenCannon" ||
                    characterz[i].name == "RascalGirl" ||
                    characterz[i].name == "DartBarrell" ||
                    characterz[i].name == "NOTINUSECH" ||
                    characterz[i].name == "NOTINUSEEG" ||
                    characterz[i].name == "NOTINUSECH" ||
                    characterz[i].name == "SpearGoblinGiant" ||
                    characterz[i].name == "REPLACEW" ||
                    characterz[i].name == "REPLACEWA" ||
                    characterz[i].name == "NOTINUSEAM" ||
                    characterz[i].name == "REPLACEED" ||
                    characterz[i].name == "REPLACEWB" )
                {
                characters[i].transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Cardzz/" + "no");
                   
                }
                else
                {
                characters[i].transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Cardzz/" + characterz[i].name);

                }
           
            
            }
        }
    }

    void Update()
    {

    }
}