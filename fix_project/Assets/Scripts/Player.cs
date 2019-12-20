using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // set a variable to cater for ship number and player number 
    float player1_hum_comp;
    float player1_ship;

    float player2_hum_comp;
    float player2_ship;

    float player3_hum_comp;
    float player3_ship;

    float player4_hum_comp;
    float player4_ship;

    //define spawn points for player ships
    public Transform Player1_SpawnPoint;
    public Transform Player2_SpawnPoint;
    public Transform Player3_SpawnPoint;
    public Transform Player4_SpawnPoint;

    //define game objects to refer to player ships
    public GameObject Ship1;
    public GameObject Ship2;
    public GameObject Ship3;
    public GameObject Ship4;
    //public  DropDownHandler theDropDownHandler;

    // Added in to create the spawnpoint for player
    // public Transform m_SpawnPoint;                          // The position and direction the ship will have when it spawns.
    //  public GameObject m_TankPrefab;                     // Reference to the prefab the players will control.
    // Start is called before the first frame update
    void Awake()
    {

        //   player1_hum_comp = theDropDownHandler.player1_playing_input;
        //    player1_ship = theDropDownHandler.player1_ship;


        player1_hum_comp = PlayerPrefs.GetFloat("player1_playing_input");
        player1_ship = PlayerPrefs.GetFloat("player1_ship");

        player2_hum_comp = PlayerPrefs.GetFloat("player2_playing_input");
        player2_ship = PlayerPrefs.GetFloat("player2_ship");

        player3_hum_comp = PlayerPrefs.GetFloat("player3_playing_input");
        player3_ship = PlayerPrefs.GetFloat("player3_ship");

        player4_hum_comp = PlayerPrefs.GetFloat("player4_playing_input");
        player4_ship = PlayerPrefs.GetFloat("player4_ship");

        Debug.Log("player1 is human pref " + player1_hum_comp);
        Debug.Log("player1 ship pref" + player1_ship);

        Debug.Log("player2 is human pref " + player2_hum_comp);
        Debug.Log("player2 ship pref" + player2_ship);

        Debug.Log("player3 is human pref " + player3_hum_comp);
        Debug.Log("player3 ship pref" + player3_ship);

        Debug.Log("player4 is human pref " + player4_hum_comp);
        Debug.Log("player4 ship pref" + player4_ship);


        for (int i = 0; i < 3; i++)
        {
            // rotate through each player to determine if they are playing or not and set the ships on board
            Debug.Log("Creating Player " + i);

            if (  i == 0)
            {
                switch (player1_hum_comp)
                {
                    case 0:
                        Debug.Log("player1 is human" + player1_hum_comp);
                        check_player1_ship();



                        break;
                    case 1:
                        Debug.Log("player1 is computer" + player1_hum_comp);
                        check_player1_ship();
                        break;
                    case 2:
                        Debug.Log("player1 is not playing" + player1_hum_comp);
                        // add in code not to show a ship
                        break;
                }
            }

            if (i == 1)
            {
                switch (player2_hum_comp)
                {
                    case 0:
                        Debug.Log("player2 is human" + player2_hum_comp);
                        check_player2_ship();



                        break;
                    case 1:
                        Debug.Log("player2 is computer" + player2_hum_comp);
                        check_player2_ship();
                        break;
                    case 2:
                        Debug.Log("player2 is not playing" + player2_hum_comp);
                        // add in code not to show a ship
                        break;
                }
            }

            if (i == 2)
            {
                switch (player3_hum_comp)
                {
                    case 0:
                        Debug.Log("player3 is human" + player3_hum_comp);
                        check_player3_ship();



                        break;
                    case 1:
                        Debug.Log("player3 is computer" + player3_hum_comp);
                        check_player3_ship();
                        break;
                    case 2:
                        Debug.Log("player3 is not playing" + player3_hum_comp);
                        // add in code not to show a ship
                        break;
                }
            }

            if (i == 3)
            {
                switch (player4_hum_comp)
                {
                    case 0:
                        Debug.Log("player4 is human" + player4_hum_comp);
                        check_player4_ship();



                        break;
                    case 1:
                        Debug.Log("player4 is computer" + player4_hum_comp);
                        check_player4_ship();
                        break;
                    case 2:
                        Debug.Log("player4 is not playing" + player4_hum_comp);
                        // add in code not to show a ship
                        break;
                }
            }



            // Code to determine if player one is human and which ship they want to play with

        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void check_player1_ship()
    {

        // Code to instantiate player 1 ship type
        switch (player1_ship)
        {
            case 0:
                Debug.Log("ship 1");

                Instantiate(Ship1, Player1_SpawnPoint.transform.position, Player1_SpawnPoint.transform.rotation);
                 Debug.Log("player1_playing_ship1" + Ship1);
                break;
            case 1:
                Debug.Log("ship2");
                Instantiate(Ship2, Player1_SpawnPoint.transform.position, Player1_SpawnPoint.transform.rotation);
                Debug.Log("player1_playing_ship1" + Ship1);
                break;
            case 2:
                Debug.Log("ship3");
                Instantiate(Ship3, Player1_SpawnPoint.transform.position, Player1_SpawnPoint.transform.rotation);
                break;
            case 3:
                Debug.Log("ship4");
                Instantiate(Ship4, Player1_SpawnPoint.transform.position, Player1_SpawnPoint.transform.rotation);
                break;
        }
    }


    void check_player2_ship()
    {

        // Code to instantiate player 2 ship type
        switch (player1_ship)
        {
            case 0:
                Debug.Log("ship 1");

                Instantiate(Ship1, Player2_SpawnPoint.transform.position, Player2_SpawnPoint.transform.rotation);

                break;
            case 1:
                Debug.Log("ship2");
                Instantiate(Ship2, Player2_SpawnPoint.transform.position, Player2_SpawnPoint.transform.rotation);
  
                break;
            case 2:
                Debug.Log("ship3");
                Instantiate(Ship3, Player2_SpawnPoint.transform.position, Player2_SpawnPoint.transform.rotation);
                break;
            case 3:
                Debug.Log("ship4");
                Instantiate(Ship4, Player2_SpawnPoint.transform.position, Player2_SpawnPoint.transform.rotation);
                break;
        }
    }


    void check_player3_ship()
    {

        // Code to instantiate player 3 ship type
        switch (player3_ship)
        {
            case 0:
                Debug.Log("ship 1");

                Instantiate(Ship1, Player3_SpawnPoint.transform.position, Player3_SpawnPoint.transform.rotation);
             
                break;
            case 1:
                Debug.Log("ship2");
                Instantiate(Ship2, Player3_SpawnPoint.transform.position, Player3_SpawnPoint.transform.rotation);
               
                break;
            case 2:
                Debug.Log("ship3");
                Instantiate(Ship3, Player3_SpawnPoint.transform.position, Player3_SpawnPoint.transform.rotation);
                break;
            case 3:
                Debug.Log("ship4");
                Instantiate(Ship4, Player3_SpawnPoint.transform.position, Player3_SpawnPoint.transform.rotation);
                break;
        }
    }

    void check_player4_ship()
    {

        // Code to instantiate player 4 ship type
        switch (player4_ship)
        {
            case 0:
                Debug.Log("ship 1");

                Instantiate(Ship1, Player4_SpawnPoint.transform.position, Player4_SpawnPoint.transform.rotation);
                Debug.Log("player4_playing_ship1" + Ship4);
                break;
            case 1:
                Debug.Log("ship2");
                Instantiate(Ship2, Player4_SpawnPoint.transform.position, Player4_SpawnPoint.transform.rotation);
                Debug.Log("player4_playing_ship1" + Ship4);
                break;
            case 2:
                Debug.Log("ship3");
                Instantiate(Ship3, Player4_SpawnPoint.transform.position, Player4_SpawnPoint.transform.rotation);
                break;
            case 3:
                Debug.Log("ship4");
                Instantiate(Ship4, Player4_SpawnPoint.transform.position, Player4_SpawnPoint.transform.rotation);
                break;
        }
    }





}
