using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveManager 
{
    public static void SavePlayerScore(AdminPuntaje adminPuntaje) 
    {
        PlayerData playerData = new PlayerData(adminPuntaje);//
        string dataPath = Application.persistentDataPath+"/puntaje.save";
        FileStream fileStream = new FileStream(dataPath, FileMode.Create);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, playerData);
        fileStream.Close();
    }

    public static PlayerData LoadPlayerScore() 
    {
        string dataPath = Application.persistentDataPath+"/puntaje.save";
        if (File.Exists(dataPath))
        {
            FileStream fileStream = new FileStream(dataPath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            PlayerData playerData = (PlayerData) binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return playerData;
        }
        else 
        { 
            Debug.LogError("No se encontro el archivo de guardado");
            return null; 
        }
    }
   
}
