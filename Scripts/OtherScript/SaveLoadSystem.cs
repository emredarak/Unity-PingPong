using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadSystem : MonoBehaviour
{
   public static void Save(SettingData data)
    {
        

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Create(Application.persistentDataPath + "save.binary");

        formatter.Serialize(saveFile, data);

        saveFile.Close();
    }

    public static SettingData Load()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Open(Application.persistentDataPath + "save.binary", FileMode.Open);

        SettingData data = (SettingData)formatter.Deserialize(saveFile);

        saveFile.Close();

        return data;
    }

}


[Serializable]
public class SettingData
{
    public float voice;
    public string difficult;

    public SettingData(float voi, string diff)
    {
        voice = voi;
        difficult = diff;
    }
}