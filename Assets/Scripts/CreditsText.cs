using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditsText : MonoBehaviour
{
    private TextMeshProUGUI credits;
    void Start()
    {
        credits = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        credits.text = GlobalStrings.LIGHTING;
    }
}
