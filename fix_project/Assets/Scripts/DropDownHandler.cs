using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownHandler : MonoBehaviour
{

    public int player1_playing_input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Setup variables for Player1 drop box for if playing/Human/Computer
    public void DropDownInput_player1_playing(int player1_playing_input)
    {
        Debug.Log("Input selected : " + player1_playing_input);
    }

    // Setup variables for Player1 ship selection
    public void DropDownInput_player1_ship(int player1_ship)
    {
        Debug.Log("Input selected : " + player1_ship);
    }


    // Setup variables for Player2 drop box for if playing/Human/Computer
    public void DropDownInput_player2_playing(int player2_playing_input)
    {
        Debug.Log("Input selected : " + player2_playing_input);
    }

    // Setup variables for Player2 ship selection
    public void DropDownInput_player2_ship(int player2_ship)
    {
        Debug.Log("Input selected : " + player2_ship);
    }


    // Setup variables for Player3 drop box for if playing/Human/Computer
    public void DropDownInput_player3_playing(int player3_playing_input)
    {
        Debug.Log("Input selected : " + player3_playing_input);
    }

    // Setup variables for Player3 ship selection
    public void DropDownInput_player3_ship(int player3_ship)
    {
        Debug.Log("Input selected : " + player3_ship);
    }

    // Setup variables for Player4 drop box for if playing/Human/Computer
    public void DropDownInput_player4_playing(int player4_playing_input)
    {
        Debug.Log("Input selected : " + player4_playing_input);
    }

    // Setup variables for Player3 ship selection
    public void DropDownInput_player4_ship(int player4_ship)
    {
        Debug.Log("Input selected : " + player4_ship);
    }

}
