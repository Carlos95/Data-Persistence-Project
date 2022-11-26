using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public string playerName;
    public string hsPlayerName;
    public int highscore;

    public static MenuManager Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public int highscore;
        public string playerName;
    }

    public void SaveHighscore(int newHighscore, string hsPlayerName)
    {
        SaveData data = new SaveData();
        data.highscore = newHighscore;
        data.playerName = hsPlayerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }

    public void LoadHighscore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            hsPlayerName = data.playerName;
            highscore = data.highscore;
        }
    }
}
