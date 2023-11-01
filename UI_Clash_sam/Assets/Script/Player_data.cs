using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player_data

{
    public string Name;
    public string Description;
    public string[] Data;
    public int ID;

    public Player_data(string _Name, string _Description, int _ID)
    {
        Name = _Name;
        Description = _Description;
        ID = _ID;
    }
    public Player_data()
    {

    }

    public void Save()
    {
        //FileSystem.instance.SaveToBinary("Player", this);
    }
}
