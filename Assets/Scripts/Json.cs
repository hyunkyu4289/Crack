using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class Json : MonoBehaviour
{
    public string jsonPath;

     void Start()
    {
        LoadLevelFromJson(jsonPath);
    }

    public void LoadLevelFromJson(string path)
    {
        TextAsset data = Resources.Load(path) as TextAsset;

        var jsonData = JSON.Parse(data.text);

        Debug.Log(jsonData.Count);

        for (int i = 0; i < jsonData.Count; i++)
        {
            Debug.Log(jsonData[i]["StageName"]);
        }
    }
}
