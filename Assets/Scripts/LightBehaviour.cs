using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    public GameObject Source;
    public GameObject Target;
    private float _maxIntensity = 10f;

    void Start()
    {
        Target.GetComponent<Transform>().position = transform.position;
        Source.GetComponent<Light>().intensity = _maxIntensity;
    }

    void Update()
    {
        float distance = Vector3.Distance(Source.transform.position, Target.transform.position);

        float intensity = CalculateIntensity(distance);

        Source.GetComponent<Light>().intensity = intensity;
    }

    float CalculateIntensity(float distance)
    {

        float intensity = _maxIntensity / (distance * distance);

        return intensity;
    }
}
