using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    public GameObject Source;
    public GameObject Player;
    public GameObject PlayerLight;

    public float maxSourceIntensity;
    public float maxPlayerIntensity;

    private Light sourceLight;
    private Light playerLight;

    void Start()
    {
        sourceLight = Source.GetComponent<Light>();
        playerLight = PlayerLight.GetComponent<Light>();

        playerLight.intensity = maxPlayerIntensity;
    }

    void Update()
    {
        float distance = Vector3.Distance(Source.transform.position, Player.transform.position);

        float sourceIntensity = CalculateSourceIntensity(distance);
        //if (distance < 10)
        //{
        //    float playerIntensity = CalculatePlayerIntensity(distance);
        //    playerLight.intensity = playerIntensity;
        //}
        sourceLight.intensity = sourceIntensity;
    }

    float CalculateSourceIntensity(float distance)
    {
        float intensity = maxSourceIntensity / (distance * distance);

        return intensity;
    }
    //float CalculatePlayerIntensity(float distance)
    //{
    //    float intensity = maxPlayerIntensity * distance * distance;

//    return intensity;
//}

}
