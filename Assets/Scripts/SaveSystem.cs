using System.Diagnostics;
using System.IO;
using System.Media;
using System.Runtime.Hosting;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void SaveLevel (Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.sve";
        FileStream stream = new FileStream(path, FileMode.Create);

        LevelData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void LoadLevel()
    {
        string path = Application.persistentDataPath + "/player.sve";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            LevelData data = formatter.Deserialize(stream) as LevelData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("File not found in " + path);
            return null;
        }
    }
}
