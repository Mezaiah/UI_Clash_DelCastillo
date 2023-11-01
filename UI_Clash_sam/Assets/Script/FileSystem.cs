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
    //public GameObject obj;
    //public GameObject obj2;
    //string positionS;
    //bool IsSaving = false;
    //public Player_data p;

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
    //void CreateFile(string _FileName, string _extension, string _data)
    //{
    //    //1) path
    //    //string FileName = "Example";
    //    //string extension = ".txt";
    //    string path = Application.dataPath + "/Resources/" + _FileName + _extension;


    //    //2)crear archivo si no existe ya uno con el mismo nombre
    //    if (!File.Exists(path))
    //    {
    //    //3)escribir dentro del archivo
    //        //File.WriteAllText(path, "");
    //    }
    //    //4)Almacenar el contenido
    //    //string data = " Login Date: " + System.DateTime.Now + "\n" + positionS;
    //    //string data = positionS;
    //    ////5)agregart la info al archivo
    //    File.AppendAllText(path, _data);


    //}

    //public void SaveToJSON(string _FIleName, object _data)
    //{
    //    string JSONData = JsonUtility.ToJson(_data);
    //    if(JSONData.Length != 0)
    //    {
    //        Debug.Log("jSON string" + JSONData);
    //        CreateFile(_FIleName,".json", JSONData);
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Tas_Wey");
    //    }

    //}
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
        
        //SaveToBinary("samuel", p);
        // //= new Player_data("Sam", "Penudo", 565656);
        //p = (Player_data)LoadFromJSON("Sam");
        ////SaveToJSON(p.Name, p);
        //string data = ReadFile("Position", ".txt");
        //Debug.Log("Información de archivo: \n " + data);
        //Vector3 position = ReadPositionFromText("Position", ".txt");
        //Debug.Log("Position from file: " + position);
        //obj2.transform.position = position;
    }

    //Update is called once per frame
    void Update()
    {
        //if (IsSaving)
        //{
            //SaveP(obj.transform);
            //CreateFile();
        //}
    }
}
