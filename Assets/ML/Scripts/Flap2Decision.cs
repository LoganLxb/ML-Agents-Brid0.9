﻿using MLAgents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flap2Decision : MonoBehaviour
{

    public float[] Decide(List<float> vectorObs, List<Texture2D> visualObs, float reward, bool done, List<float> memory)
    {
        return new float[0];
    }

    public List<float> MakeMemory(List<float> vectorObs, List<Texture2D> visualObs, float reward, bool done, List<float> memory)
    {
        return new List<float>();
    }
}
