using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject Target;
    Vector3 yAxis = new Vector3(1, 1, 0);
    void Start()
    {
        Target.GetComponent<Transform>().position = transform.position;
        
    }

    void Update()
    {
        transform.LookAt(Target.transform);
        
        transform.position = new Vector3(Target.transform.position.x + 5, Target.transform.position.y + 5,
            Target.transform.position.z - 5);
    }
}
