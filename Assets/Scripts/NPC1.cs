using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPC : MonoBehaviour
{
    bool canInteract;
    public Prompt p1;
    public Dialogue dia;
    public bool alreadyInteracted;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       if(p1.interaction && !alreadyInteracted && !dia.typing)
        {
            dia.startDialogue();
            alreadyInteracted = true;
        }
       
       
        

    }

    private void OnTriggerEnter(Collider other)
    {
        canInteract = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canInteract = false;
        alreadyInteracted = false;
        p1.interaction = false;
    }

    public bool interactible()
    {
        return canInteract;
    }

}
