using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStone : MonoBehaviour
{
    DiceRoller theDiceRoller;

    void Start()
    {
        // Gain access to the DiceRoller class
        theDiceRoller = GameObject.FindObjectOfType<DiceRoller>();
    }

    public Tile StartingTile;
    Tile currentTile;

    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        // We are able to use mouse commands because our object
        // has a Rigidbody component. 
        Debug.Log("Click!");

        // Have we rolled the dice?
        // TODO: Is it our turn?
        if(theDiceRoller.IsDoneRolling == false)
        {
            // We can't move yet.
            return;
        }

        int spacesToMove = theDiceRoller.DiceTotal;

        // Where should we end up?

        Tile finalTile = currentTile;

        for (int i = 0; i < spacesToMove; i++)
        {
            if (finalTile == null)
            {
                finalTile = StartingTile;
            }
            else
            {
                finalTile = currentTile.NextTiles[0];
            }
        }
        
        if(finalTile == null)
        {
            // We moved an off-board tile by zero.
            return;
        }

        // Teleport the tile to the final tile
        // TODO: ANimate!

        this.transform.position = finalTile.transform.position;

        currentTile = finalTile;


    }
}
