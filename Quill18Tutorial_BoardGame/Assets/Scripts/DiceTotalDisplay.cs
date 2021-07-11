using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DiceTotalDisplay : MonoBehaviour
{
    DiceRoller theDiceRoller;

    void Start()
    {
        theDiceRoller = GameObject.FindObjectOfType<DiceRoller>();
    }


    void Update()
    {
        if(theDiceRoller.IsDoneRolling == false)
        {
            GetComponent<Text>().text = "= ?";
        }
        else
        {
            GetComponent<Text>().text = "= " + theDiceRoller.DiceTotal;
        }
    }
}
