using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SaveData;

public class DataManager : MonoBehaviour
{
     void Update()
    {
        if (Input.GetKeyDown("s")) // 저장
        {
            SaveData Note = new SaveData(100, 10, 9, 2);

            SaveSystem.Save(Note, "save_001");
        }

        if (Input.GetKeyDown("l")) // 불러오기
        {
            SaveData loadData = SaveSystem.Load("save_001");
            Debug.Log(string.Format("LoadData Result => Time : {0}, LaneIndex : {1}, NoteType : {2}, Duration : {3}", loadData.Time, loadData.LaneIndex, loadData.NoteType, loadData.Duration));
        }
    }
}

