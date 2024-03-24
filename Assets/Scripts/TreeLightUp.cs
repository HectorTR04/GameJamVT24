using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLightUp : MonoBehaviour
{
    public GameObject Player;
    
    public Light treeLight;

    void Start()
    {
        
    }

    void Update()
    {
        if (Vector3.Distance(Player.transform.position, transform.position) <= 5) 
        {
            treeLight.intensity = 5;
        }
        else
        {
            treeLight.intensity = 0;
        }
    }
}
