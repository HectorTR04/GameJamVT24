using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject WorldBorder;
    public BoxCollider _spawnArea;
    private Bounds _bounds;
    public Objective[] Objectives;
    public GameObject Player;
    public List<LightType> ActivationOrder;
    public List<LightType> TrueOrder;    
    
    void Start()
    {

        ActivationOrder = new List<LightType>();
        Objectives[0].ObjectiveType = LightType.Red;
        Objectives[1].ObjectiveType = LightType.Green;
        Objectives[2].ObjectiveType = LightType.Blue;
        Objectives[3].ObjectiveType = LightType.Purple;
        Objectives[4].ObjectiveType = LightType.Orange;
        TrueOrder = new List<LightType>()
        {
            LightType.Red,
            LightType.Green,
            LightType.Blue,
            LightType.Purple,
            LightType.Orange,
        };
    }

    void Update()
    {
        PlayerActivateObjective();
        CheckActivationOrder();
        CheckBorders();
    }

    void PlayerActivateObjective()
    {
        foreach (Objective objective in Objectives)
        {
            if (Vector3.Distance(Player.transform.position, objective.transform.position) < 5
                && Input.GetKeyDown(KeyCode.Space))
            {
                objective.Activated = true;
            }
            if (objective.Activated && !ActivationOrder.Contains(objective.ObjectiveType))
            {
                ActivationOrder.Add(objective.ObjectiveType);
            }
        }
    }
    void CheckActivationOrder()
    {
        for (int i = 0; i < ActivationOrder.Count; i++)
        {
            if (ActivationOrder[i] != TrueOrder[i])
            {
                SceneManager.LoadScene(2);
                return;
            }
            if (ActivationOrder[i] == TrueOrder[i] && ActivationOrder.Count == TrueOrder.Count)
            {
                SceneManager.LoadScene(3);
            }
        }
    }

    void CheckBorders()
    {
        float distanceThreshold = 50f; 

        float distanceFromOrigin = Vector3.Distance(Player.transform.position, Vector3.zero);

        if (distanceFromOrigin > distanceThreshold)
        {
            SceneManager.LoadScene(2);
        }
    }
}

