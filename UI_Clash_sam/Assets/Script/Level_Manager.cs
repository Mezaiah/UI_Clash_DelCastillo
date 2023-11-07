using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using SimpleJSON;
using TMPro;


public class Level_Manager : MonoBehaviour
{
    public List<CR_Character> characterz;
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;
    public GameObject character5;
    public GameObject character6;
    public GameObject character7;
    public GameObject character8;
    public GameObject character9;
    public GameObject character10;
    public GameObject character11;
    public GameObject character12;
    public GameObject character13;
    public GameObject character14;
    public GameObject character15;
    public GameObject character16;
    public GameObject character17;
    public GameObject character18;
    public GameObject character19;
    public GameObject character20;
    public GameObject character21;
    public GameObject character22;
    public GameObject character23;
    public GameObject character24;
    public GameObject character25;
    public GameObject character26;
    public GameObject character27;
    public GameObject character28;
    public GameObject character29;
    public GameObject character30;
    public GameObject character31;
    public GameObject character32;
    public GameObject character33;
    public GameObject character34;
    public GameObject character35;
    public GameObject character36;
    public GameObject character37;
    public GameObject character38;
    public GameObject character39;
    public GameObject character40;
    public GameObject character41;
    public GameObject character42;
    public GameObject character43;
    public GameObject character44;
    public GameObject character45;
    public GameObject character46;
    public GameObject character47;
    public GameObject character48;
    public GameObject character49;
    public GameObject character50;
    public GameObject character51;
    public GameObject character52;
    public Sprite pepe;

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
    // Start is called before the first frame update
    void Start()
    {
        characterz = new List<CR_Character>();
        LoadCharacter("characters");
        //FileSystem.instance.LoadCharacter("characters");
        //CR_Character CharData = FileSystem.instance.LoadFromJSON<CR_Character>("characters");
        //Knight

        //for (int i = 0; i < 70; i++)
        //{
            character52.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[0].name;
        character52.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[0].id.ToString();
        character52.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Cardzz/" + characterz[0].name);


        //}


        //Knight
        character1.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[0].name;
        character1.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[0].id.ToString();
        //Archer
        character2.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[1].name;
        character2.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[1].id.ToString();
        //Goblin
        character3.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[2].name;
        character3.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[2].id.ToString();
        //Giant
        character4.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[3].name;
        character4.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[3].id.ToString();
        //Pekka
        character5.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[4].name;
        character5.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[4].id.ToString();
        //Minion
        character6.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[5].name;
        character6.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[5].id.ToString();
        //Balloon
        character7.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[6].name;
        character7.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[6].id.ToString();
        //Witch
        character8.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[7].name;
        character8.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[7].id.ToString();
        //Skeleton
        character9.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[8].name;
        character9.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[8].id.ToString();
        //Barbarian
        character10.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[9].name;
        character10.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[9].id.ToString();
        //Golem
        character11.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[10].name;
        character11.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[10].id.ToString();
        //Valyrie
        character12.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[12].name;
        character12.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[12].id.ToString();
        //Bomber
        character13.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[13].name;
        character13.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[13].id.ToString();
        //Musketeer
        character14.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[14].name;
        character14.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[14].id.ToString();
        //Baby_Dragon
        character15.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[15].name;
        character15.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[15].id.ToString();
        //mini_peeka
        character16.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[16].name;
        character16.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[16].id.ToString();
        //wizard
        character17.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[17].name;
        character17.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[17].id.ToString();
        //prince
        character18.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[18].name;
        character18.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[18].id.ToString();
        //Spear_goblin
        character19.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[19].name;
        character19.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[19].id.ToString();
        //giant_Skelleton
        character20.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[20].name;
        character20.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[20].id.ToString();
        //Hog_Rider
        character21.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[21].name;
        character21.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[21].id.ToString();
        //Ice_wizard
        character22.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[23].name;
        character22.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[23].id.ToString();
        //Royal_Giant
        character23.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[24].name;
        character23.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[24].id.ToString();
        //Princess
        character24.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[25].name;
        character24.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[25].id.ToString();
        //Dark_prince
        character25.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[26].name;
        character25.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[26].id.ToString();
        //skeleton_Warrior
        character26.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[27].name;
        character26.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[27].id.ToString();
        //lava_Hound
        character27.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[28].name;
        character27.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[28].id.ToString();
        //Ice_Spirits
        character28.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[31].name;
        character28.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[31].id.ToString();
        //fire_Spirits
        character29.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[32].name;
        character29.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[32].id.ToString();
        //miner
        character30.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[33].name;
        character30.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[33].id.ToString();
        //Zap_Machine
        character31.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[34].name;
        character31.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[34].id.ToString();
        //bowler
        character32.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[35].name;
        character32.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[35].id.ToString();
        //Ice_Golem
        character33.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[36].name;
        character33.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[36].id.ToString();
        //megaminion
        character34.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[37].name;
        character34.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[37].id.ToString();
        //Inf_Dragon
        character35.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[38].name;
        character35.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[38].id.ToString();
        //Battle_Ram
        character36.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[39].name;
        character36.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[39].id.ToString();
        //Blowdart_goblin
        character37.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[40].name;
        character37.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[40].id.ToString();
        //Electro_Wizard
        character38.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[41].name;
        character38.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[41].id.ToString();
        //Axe_man +01
        character39.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[43].name;
        character39.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[43].id.ToString();
        //Ghost +02
        character40.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[46].name;
        character40.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[46].id.ToString();
        //hunter +01
        character41.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[48].name;
        character41.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[48].id.ToString();
        //dark Witch
        character42.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[49].name;
        character42.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[49].id.ToString();
        //bat
        character43.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[50].name;
        character43.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[50].id.ToString();
        //recruit
        character44.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[51].name;
        character44.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[51].id.ToString();
        //Rascal
        character45.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[52].name;
        character45.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[52].id.ToString();
        //moving_Canon
        character46.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[53].name;
        character46.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[53].id.ToString();
        //mega_Knight +01
        character47.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[55].name;
        character47.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[55].id.ToString();
        //skeleton_balloon +01
        character48.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[57].name;
        character48.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[57].id.ToString();
        //royal hog +02
        character49.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[60].name;
        character49.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[60].id.ToString();
        //goblinGiant +01
        character50.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[62].name;
        character50.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[62].id.ToString();
        //elite_Archer
        character51.transform.GetChild(1).GetComponent<TMP_Text>().text = characterz[63].name;
        character51.transform.GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = characterz[63].id.ToString();




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
