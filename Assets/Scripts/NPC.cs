using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Vector3 NPCposition;
    public GameObject Player;
    bool canInteract;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        

    }

    private void OnTriggerEnter(Collider other)
    {
        canInteract = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canInteract = false;
    }

    public bool interactible()
    {
        return canInteract;
    }

}
