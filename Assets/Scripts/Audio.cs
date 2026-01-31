using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Audio : MonoBehaviour
{
    double SongStartTime;
    double SongPosition;

    void Start()
    {
        PlaySong();
    }

    public void PlaySong()
    {
        SongStartTime = AudioSettings.dspTime;
    }

    private void Update()
    {
       SongPosition = AudioSettings.dspTime - SongStartTime;

       Debug.Log("Song Position: " + SongPosition);
    }
}
