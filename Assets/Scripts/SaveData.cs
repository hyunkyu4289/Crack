using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData
{
     public SaveData(double _Time, int _LaneIndex ,int _NoteType, double _Duration)
     {
        Time = _Time;
        LaneIndex = _LaneIndex;
        NoteType = _NoteType;
        Duration = _Duration;
     }

     public double Time;
     public int LaneIndex;
     public int NoteType;
     public double Duration;

    public static class SaveSystem
    {
        private static string SavePath => Application.persistentDataPath + "/saves/"; // Application.persistentDataPath 는 datapath 와 달리 읽고 쓰는 파일을 저장 용이

        public static void Save (SaveData saveData, string saveFileName)
        {
            if (!Directory.Exists(SavePath)) // 만약에 세이브 폴더가 존재하지 않는다면 참고) Dirextory - 폴더 Exists - 폴더 존재 여부를 확인 (bool값)
            {
                Directory.CreateDirectory(SavePath); // 세이브 폴더를 만들어라
            }

            string saveJson = JsonUtility.ToJson(saveData);

            string saveFilePath = SavePath + saveFileName + ".json";
            File.WriteAllText(saveFilePath, saveJson); // File.WriteAllText는 새파일을 만들고 문자열을 저장후 닫는다 만약에 파일이 이미 있다면 덮어씌운다
            Debug.Log("Save Success: " + saveFilePath);
        }
        public static SaveData Load(string saveFileName)
        {
            string saveFilePath = SavePath + saveFileName + ".json";

            if (!File.Exists(saveFilePath))
            {
                Debug.LogError("No such saveFile exists");
                return null;
            }
            string saveFile = File.ReadAllText(saveFilePath);
            SaveData saveData = JsonUtility.FromJson<SaveData>(saveFile);
            return saveData;
        }
    }
}
