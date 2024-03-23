using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
    }

    void PlayerActivateObjective()
    {
        foreach (Objective objective in Objectives)
        {
            if (Vector3.Distance(Player.transform.position, objective.transform.position) < 5
                /*and press spsace*/)
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
                Debug.Log("Activation order doesn't match the true order: Incorrect order.");
                //player die
                return;
            }
            if (ActivationOrder[i] == TrueOrder[i] && ActivationOrder.Count == TrueOrder.Count)
            {
                Debug.Log("correct order");
                //player win
            }
        }
    }
}

