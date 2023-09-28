using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]

public struct CRData
{
    public int Level;
    public int Gold;
    public int Emeralds;
    public string User;
    public string Clan;
}

public class MainMenu_Data : MonoBehaviour
{
    [Header("Main Menu Config")]
    public CRData Data;
    [Header("MAIN MENU UI")]
    
    public TMP_Text Level;
    public TMP_Text Gold;
    public TMP_Text Emeralds;
    public TMP_Text User;
    public TMP_Text Clan;


    void Start()
    {
        Level.text = Data.Level.ToString() + "/100";
        Gold.text = Data.Gold.ToString();
        Emeralds.text = Data.Emeralds.ToString();
        User.text = Data.User;
        Clan.text = Data.Clan;
    }

    // Update is called once per frame
    void Update()
    {
        Level.text = Data.Level.ToString() + "/100";
        Gold.text = Data.Gold.ToString();
        Emeralds.text = Data.Emeralds.ToString();
        User.text = Data.User;
        Clan.text = Data.Clan;
    }
}
