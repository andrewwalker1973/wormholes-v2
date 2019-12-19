using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShips : MonoBehaviour
{


    DiceRoller theDiceRoller;

    //added in for smooth move
    Vector3 targetPosition;
    Vector3 velocity;
    float smoothTime = 0.15f;
    float smoothTimeVertical = 0.1f;
    float smoothDistance = 0.01f;
    float smoothHeight = 35f;

    public Tile startingTile;
    Tile currentTile;


    // added into handle player moving off board
    bool scoreMe = false;

    // added in to keep record of tiles to move across
    Tile[] moveQueue;
    int moveQueueIndex;




    // Start is called before the first frame update
    void Start()
    {
        theDiceRoller = GameObject.FindObjectOfType<DiceRoller>();

        targetPosition = this.transform.position;

        Debug.Log("at start this.transform.position  " + this.transform.position);
        Debug.Log("at start targetPosition  " + targetPosition);

       

    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(
            new Vector3(this.transform.position.x, targetPosition.y, this.transform.position.z),
            targetPosition)
            < smoothDistance)
        {

            // reached the target how is the height
            if (moveQueue != null && moveQueueIndex == (moveQueue.Length) && this.transform.position.y > smoothDistance)
            {
                this.transform.position = Vector3.SmoothDamp(
                this.transform.position,
                new Vector3(this.transform.position.x, 0, this.transform.position.z),
                ref velocity,
                smoothTimeVertical);
            }
            else
            {
                //right position and rihht height, advance the queue
                AdvancedMoveQueue();
            }

        }
        // move the player up a bit before we move to new location
        else if (this.transform.position.y < (smoothHeight - smoothDistance))
        {
            this.transform.position = Vector3.SmoothDamp(
            this.transform.position,
            new Vector3(this.transform.position.x, smoothHeight, this.transform.position.z),
            ref velocity,
            smoothTimeVertical);

        }
        else
        {
            this.transform.position = Vector3.SmoothDamp(
            this.transform.position,
            new Vector3(targetPosition.x, smoothHeight, targetPosition.z),
            ref velocity,
            smoothTime);
        }
    }


    void AdvancedMoveQueue()
    {
        if (moveQueue != null && moveQueueIndex < moveQueue.Length)
        {
            Tile nextTile = moveQueue[moveQueueIndex];
            if (nextTile == null)
            {
                // we are being scored move player off board
                //TODO something for end game winner, maybe move to winner area ?
                SetNewTargetPosition(this.transform.position + Vector3.right * 100f);

            }
            else
            {
                SetNewTargetPosition(nextTile.transform.position);
                moveQueueIndex++;
            }
        }
    }

    void SetNewTargetPosition(Vector3 pos)
    {
        targetPosition = pos;
        velocity = Vector3.zero;
    }

    void OnMouseUp()
    {

        if (theDiceRoller.IsDoneRolling == false)
        {
            //we cant move yet

            //CHECK TO MAKE SURE THERE IS NO ui OBJECT IN THE WAY
            return;

        }
        int spacesToMove = theDiceRoller.DiceTotal;

        if (spacesToMove == 0)
        {
            return;
        }

        //Debug.Log("Spaces to move" + spacesToMove);
        // Andrew, this does not seem to be coming though correctly

        moveQueue = new Tile[spacesToMove];
        //    Debug.Log("on mouse up movequeue - should be Tile[3] " + moveQueue);
        //   Debug.Log("new Tile[spacesToMove] - should be Tile[3] " + new Tile[spacesToMove]);

        // why does this seem like im not goping anywhere

        Tile finalTile = currentTile;

        //     Debug.Log("AW finalTile == " + finalTile);
        //      Debug.Log("AW currentTile == " + currentTile);
        //where should we move to ?

        // check if dice roll == 0  if 0 then exit out as we cant move?



        //      Debug.Log("AW moveQueue == " + moveQueue);     

        for (int i = 0; i < spacesToMove; i++)
        {
            //  check if no tile? ie off board ?
            if (finalTile == null && scoreMe == false)
            {
                finalTile = startingTile;
            }
            else
            {

                if (finalTile.NextTiles == null || finalTile.NextTiles.Length == 0)
                {
                    // TODO  we have reached the end and score player
                    //   Debug.Log("Score!!!!!");
                    //   Destroy(gameObject);
                    //   return;
                    scoreMe = true;
                    finalTile = null;
                }
                else if (finalTile.NextTiles.Length > 1)
                {
                    // branch based on player ID
                    finalTile = finalTile.NextTiles[0];
                }
                else
                {
                    finalTile = finalTile.NextTiles[0];
                }


            }
            moveQueue[i] = finalTile;
        }


        // Teleport tile to end tile
        //TODO ANIMATE
        // Stop the teleport to location        this.transform.position = finalTile.transform.position;
        // removed to do no cutting corners      SetNewTargetPosition( finalTile.transform.position );
        moveQueueIndex = 0;
        currentTile = finalTile;
        // try force the position -- was able to move here but did not work
        /// targetPosition = this.transform.position;
        Debug.Log("st the end of the loop set current tile to final tile  " + currentTile);

    }
}