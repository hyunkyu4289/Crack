using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parsing : MonoBehaviour
{
    private void Start()
    {
        DataParsing();
    }

    void DataParsing()
    {
        var lodeJson = Resources.Load<TextAsset>("Json/NoteData");

        NoteData data = JsonUtility.FromJson<NoteData>(lodeJson.ToString());

        Debug.Log($"{data.Time}, {data.LaneIndex}, {data.NoteType}, {data.Duration}");
    }
}
