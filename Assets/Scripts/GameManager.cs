using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] LightObjectives;
    public int[] ActivationOrder;

    void Start()
    {
        ActivationOrder = new int[LightObjectives.Length];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
