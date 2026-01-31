using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

[System.Serializable]
public class NoteData
{
    public double Time;
    public int LaneIndex;
    public int NoteType;
    public double Duration;
}
