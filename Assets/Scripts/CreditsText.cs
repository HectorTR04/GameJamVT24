using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditsText : MonoBehaviour
{
    private TextMeshProUGUI credits;
    private float timer;
    void Start()
    {
        credits = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0 && timer < 5)
        {
            credits.text = GlobalStrings.LIGHTING;
        }
        if (timer > 5 && timer < 10)
        {
            credits.text = GlobalStrings.SHAKESPEARE;
        }
        if (timer > 10 && timer < 15)
        {
            credits.text = GlobalStrings.ANIMATION;
        }
        if (timer > 15 && timer < 20)
        {
            credits.text = GlobalStrings.PROGRAMMING;
        }
    }
}
