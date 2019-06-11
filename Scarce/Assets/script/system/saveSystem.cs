using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class saveSystem 
{
    public static void NewData()
    {

    }

    public static void SaveData(plyrObj plyr)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/pdata.scarce";
        FileStream stream = new FileStream(path, FileMode.Create);

        plyrData data = new plyrData(plyr);

        formatter.Serialize(stream, data);
        Debug.Log("data saved at " + path);
        stream.Close();
    }

    public static plyrData LoadData()
    {
        string path = Application.persistentDataPath + "/pdata.scarce";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            plyrData data = formatter.Deserialize(stream) as plyrData;

            Debug.Log("data loaded from " + path);

            return data;
        }
        else
        {
            Debug.Log("no data found at " + path);
            return null;
        }
    }

    public static bool FileCheck()
    {
        string path = Application.persistentDataPath + "/pdata.scarce";

        if (File.Exists(path))
        {
            return true;
        }
        else { return false; }
    }
}
