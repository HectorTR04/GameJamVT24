using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinAnimation : MonoBehaviour
{
    public GameObject Player;
    public Light PlayerLight;
    private float timeToTransition = 5f;
    private float timer;
    void Start()
    {
       PlayerLight.intensity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToTransition)
        {
            SceneManager.LoadScene(4);
        }
        PlayerLight.intensity += Time.deltaTime * 100;
    }
}
