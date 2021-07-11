using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour
{
    public int[] DiceValues;

    void Start()
    {
        DiceValues = new int[4];
    }


    public int DiceTotal;

    public bool IsDoneRolling = false;

    public Sprite[] DiceImageOne;
    public Sprite[] DiceImageZero;

    public void NewTurn()
    {
        // This is the start of a player's turn.
        // We don't have a roll for them yet.
        IsDoneRolling = false;
    }

    public void RollTheDice()
    {
        // In Ur, you roll four dice. Half of each die is 1, the other is 0.
        // I am using random number generation instead.

        DiceTotal = 0;

        for (int i = 0; i < DiceValues.Length; i++)
        {
            DiceValues[i] = Random.Range( 0, 2 );
            DiceTotal += DiceValues[i];


            // Update the visuals to show the dice roll
            // TODO: This could include playing an animation -- 2D or 3D

            // We have 4 children, each is an image of the die. So grab that
            // child, and update its Image component to use the correct Sprite.

            if(DiceValues[i] == 0)
            {
                this.transform.GetChild(i).GetComponent<Image>().sprite =
                    DiceImageZero[Random.Range(0, DiceImageZero.Length)];
            }
            else
            {
                this.transform.GetChild(i).GetComponent<Image>().sprite =
                    DiceImageOne[Random.Range(0, DiceImageOne.Length)];
            }

            // If we had an animation, we'd have to wait for it to finish before
            // we set doneRolling, but we can just set it right away
            IsDoneRolling = true;
        }

        //Debug.Log("Rolled: " + DiceTotal);


    }
}
