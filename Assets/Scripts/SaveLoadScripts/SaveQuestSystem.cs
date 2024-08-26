using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveQuestSystem
{
    
    public static void SaveQuests(MasterQuestHandler masterQuestHandlerScript)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/questData.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        QuestData data = new QuestData(masterQuestHandlerScript);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static QuestData LoadQuests()
    {
        string path = Application.persistentDataPath + "/questData.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            QuestData data = formatter.Deserialize(stream) as QuestData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File not found in " + path);
            return null;
        }
    }

}
