using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Prompt : MonoBehaviour
{
    public Renderer rend;
    public NPC npc;
    public bool interaction;
    public int npcIndex;
   
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
       
        rend.enabled = true;
        Hide();
    }

    void Show()
    {
        rend.enabled = true;
    }

    void Hide()
    {
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (npc.interactible() && interaction == true)
        {
            Hide();
        }
        else if (npc.interactible()) 
        {
            Show();
            if (Input.GetKeyDown(KeyCode.E))
            {
                interaction = true;
            }
        }
        else
        {
            Hide();
        }

        if(interaction && !npc.interactible())
        {
            interaction = false;
        }
    }

    


}
