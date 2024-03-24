using UnityEngine;

public class Objective : MonoBehaviour
{
    public bool Activated { get; set; } = false;
    public LightType ObjectiveType { get; set; }
    [SerializeField] Material material1;
    [SerializeField] Material material2;
    MeshRenderer rend;


    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        rend.material = material1;
    }

    void Update()
    {
        LightUp();
    }

    void LightUp()
    {
        if (Activated)
        {
            rend.material = material2;
        }
    }
}

