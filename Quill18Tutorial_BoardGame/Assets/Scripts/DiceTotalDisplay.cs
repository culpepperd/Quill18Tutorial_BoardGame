using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DiceTotalDisplay : MonoBehaviour
{
    void Start()
    {
        theDiceRoller = GameObject.FindObjectOfType<DiceRoller>();
    }

    DiceRoller theDiceRoller;

    void Update()
    {
        if(theDiceRoller.doneRolling == false)
        {
            GetComponent<Text>().text = "= ?";
        }
        else
        {
            GetComponent<Text>().text = "= " + theDiceRoller.DiceTotal;
        }
    }
}
