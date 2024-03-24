using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textcomponent;
    public string line;
    public float textSpeed;
    private int index;
    public bool typing;
    public float textBuffer;
    

    // Start is called before the first frame update
    void Start()
    {
        textcomponent.text = string.Empty;
        textBuffer = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
        //    textcomponent.text = string.Empty;
        //}
        if (textcomponent.text.Length == line.Length)
        {
            textBuffer -= Time.deltaTime;
            if(textBuffer <= 0f)
            {
                textcomponent.text = string.Empty;
                textBuffer = 2f;
            }
            
            //StartCoroutine(typeLine());
        }


    }

    public void startDialogue()
    {
        
        StartCoroutine(typeLine());
    }

    IEnumerator typeLine()
    {
        typing = true;
        foreach(char c in line.ToCharArray() )
        {
            textcomponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
        typing = false;
    }

    


}
