using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using UnityEngine.Rendering;
using System.Runtime.Serialization.Formatters.Binary;

public class FileSystem : MonoBehaviour
{
    public static FileSystem instance;
    

    private void Awake()
    {
        if(instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }
    
    string ReadFile(string _FileName, string _Extension)
    {
        
        string path = Application.dataPath + "/Resources/" + _FileName + _Extension;
        string data = "";
        if (File.Exists(path))
        {
            data = File.ReadAllText(path);
        }
       
        return data;
    }

    //Vector3 ReadPositionFromText(string _FileName, string _Extension)
    //{
    //    string path = Application.dataPath + "/Resources/" + _FileName + _Extension;
    //    Vector3 position = Vector3.zero;

    //    if (File.Exists(path))
    //    {

    //        string data = File.ReadAllText(path);

           
    //        data = data.Replace("(", "").Replace(")", "");
    //        string[] components = data.Split(',');

    //        if (components.Length == 3)
    //        {
    //            float x, y, z;

    //            if (float.TryParse(components[0], out x) && float.TryParse(components[1], out y) && float.TryParse(components[2], out z))
    //            {
    //                position = new Vector3(x, y, z);
    //                return position;
    //            }
    //        }

    //        Debug.LogError("Failed to parse Vector3 from file data.");
    //    }
    //    else
    //    {
    //        Debug.LogError("File does not exist: " + path);
    //    }
    //    return position;
    //}

    //public void SaveP(Transform tr)
    //{
    //    Vector3 position = obj.transform.position;
    //    positionS = position.ToString();
    //    Debug.Log(positionS);
    //}

    //Player_data LoadFromJSON(string _FileName)
    //{
    //    Player_data data = new Player_data();
       
    //    string JSONData = ReadFile(_FileName, ".json");
    //    if (JSONData.Length != 0)
    //    {
    //        Debug.Log("Data: " + JSONData);
    //        JsonUtility.FromJsonOverwrite(JSONData, data);
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Tas_Wey");
    //    }
    //    return data;
    //}

    
   public  T LoadFromJSON<T>(string _fileName) where T : new()
    {
        T data = new T();
        string JSonData = ReadFile(_fileName, ".json");
        //string DataRead = 
        if(JSonData.Length != 0)
        {
            Debug.Log("data: " + JSonData);
            JsonUtility.FromJsonOverwrite(JSonData, data);
        }
        else
        {
            Debug.Log("tas ReWey");
        }
        return data;
    }
    
   
    
    //public void SaveToBinary(string _FIleName, object _data)
    //{
    //    //creamos un formateador de binarios
    //    BinaryFormatter bf = new BinaryFormatter();
    //    //obtener el path para guardar y asignar el archivo binary
    //    string path = Application.dataPath + "/Resources/" + _FIleName + ".file";
    //    //crear un archvio
    //    FileStream stream = new FileStream(path, FileMode.Create);
    //    //serializar la info y guardar
    //    bf.Serialize(stream, _data);
    //    //cerrar archivo
    //    stream.Close();
        
    //}
    void Start()
    {
        
       
    }

    //Update is called once per frame
    void Update()
    {
       
    }
}
