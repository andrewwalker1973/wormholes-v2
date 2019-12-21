using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownHandler : MonoBehaviour
{
    // Define base var for player = 2 ( not playing) and ship 1
    public int player1_playing_input = 0;
    public int player1_ship = 0;

    public int player2_playing_input = 1;
    public int player2_ship = 0 ;

    public int player3_playing_input = 2;
    public int player3_ship= 0 ;

    public int player4_playing_input = 2;
    public int player4_ship = 0 ;

   
   
         


    // Start is called before the first frame update
    void Start()
    {
        // Add in code to reset player prefs 
        PlayerPrefs.SetFloat("player1_playing_input", player1_playing_input);
        PlayerPrefs.SetFloat("player2_playing_input", player2_playing_input);
        PlayerPrefs.SetFloat("player3_playing_input", player3_playing_input);
        PlayerPrefs.SetFloat("player4_playing_input", player4_playing_input);

        PlayerPrefs.SetFloat("player1_ship", player1_ship);
        PlayerPrefs.SetFloat("player2_ship", player2_ship);
        PlayerPrefs.SetFloat("player3_ship", player3_ship);
        PlayerPrefs.SetFloat("player4_ship", player4_ship);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Setup variables for Player1 drop box for if playing/Human/Computer
    public void DropDownInput_player1_playing(int player1_playing_input)
    {
        Debug.Log("Input selected : " + player1_playing_input);
        PlayerPrefs.SetFloat("player1_playing_input", player1_playing_input);
    }

    // Setup variables for Player1 ship selection
    public void DropDownInput_player1_ship(int player1_ship)
    {
        Debug.Log("Input selected : " + player1_ship);
        PlayerPrefs.SetFloat("player1_ship", player1_ship);
    }


    // Setup variables for Player2 drop box for if playing/Human/Computer
    public void DropDownInput_player2_playing(int player2_playing_input)
    {
        Debug.Log("Input selected : " + player2_playing_input);
        PlayerPrefs.SetFloat("player2_playing_input", player2_playing_input);
    }

    // Setup variables for Player2 ship selection
    public void DropDownInput_player2_ship(int player2_ship)
    {
        Debug.Log("Input selected : " + player2_ship);
        PlayerPrefs.SetFloat("player2_ship", player2_ship);
    }


    // Setup variables for Player3 drop box for if playing/Human/Computer
    public void DropDownInput_player3_playing(int player3_playing_input)
    {
        Debug.Log("Input selected : " + player3_playing_input);
        PlayerPrefs.SetFloat("player3_playing_input", player3_playing_input);
    }

    // Setup variables for Player3 ship selection
    public void DropDownInput_player3_ship(int player3_ship)
    {
        Debug.Log("Input selected : " + player3_ship);
        PlayerPrefs.SetFloat("player3_ship", player3_ship);

    }

    // Setup variables for Player4 drop box for if playing/Human/Computer
    public void DropDownInput_player4_playing(int player4_playing_input)
    {
        Debug.Log("Input selected : " + player4_playing_input);
        PlayerPrefs.SetFloat("player4_playing_input", player4_playing_input);
    }

    // Setup variables for Player3 ship selection
    public void DropDownInput_player4_ship(int player4_ship)
    {
        Debug.Log("Input selected : " + player4_ship);
        PlayerPrefs.SetFloat("player4_ship", player4_ship);
    }

}
