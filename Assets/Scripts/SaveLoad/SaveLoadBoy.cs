using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadBoy
{
    public static void SaveBoy(HealthScore player, PlayerMovement gender)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path;
        if (gender.gender == "XY")
        {
            path = Application.persistentDataPath + "/saves.boy";
        } else
        {
            path = Application.persistentDataPath + "/saves.girl";
        }
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerDataBoy data = new PlayerDataBoy(player);

        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static PlayerDataBoy LoadBoy(PlayerMovement gender)
    {
        string path;
        if (gender.gender == "XY")
        {
            path = Application.persistentDataPath + "/saves.boy";
        }
        else
        {
            path = Application.persistentDataPath + "/saves.girl";
        }
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerDataBoy data = formatter.Deserialize(stream) as PlayerDataBoy;

            stream.Close();
            return data;
        }
        else
            return null;
    }

    public static void Delete()
    {
        File.Delete(Application.persistentDataPath + "/saves.boy");
        File.Delete(Application.persistentDataPath + "/saves.girl");
        File.Delete(Application.persistentDataPath + "/saves.level");
    }

    public static void SaveGameLevel(LevelNumber number)
    {
        string path = Application.persistentDataPath + "/saves.level";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveLevel data = new SaveLevel(number);

        formatter.Serialize(stream, data);

        stream.Close();
    }
 
    public static SaveLevel LoadGameLevel()
    {
        string path = Application.persistentDataPath + "/saves.level";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            SaveLevel data = formatter.Deserialize(stream) as SaveLevel;

            stream.Close();

            return data;
        }
        else
            return null;
    }
}
