using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSV : MonoBehaviour
{
    public string filePath;

     void Start()
    {
       var data = CSVReader.Read(filePath);

        Debug.Log(data[0]["StageName"]);
    }
}
