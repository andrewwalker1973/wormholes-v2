using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   



    DropDownHandler theDropDownHandler;

    // Added in to create the spawnpoint for player
    public Transform m_SpawnPoint;                          // The position and direction the ship will have when it spawns.
                                                            //  public GameObject m_TankPrefab;                     // Reference to the prefab the players will control.
                                                            // Start is called before the first frame update
    void Start()
    {

        theDropDownHandler = GameObject.FindObjectOfType<DropDownHandler>();
        // Temp Values for debug of sapwn point
        
      //  if (theDropDownHandler.player1_playing_input = 0)
     //   {
     //       Debug.Log("player1 value  " + theDropDownHandler.player1_playing_input);
     //   }
    

        //Added in to set the players in the spawn point
        // m_Tanks[i].m_Instance =
        //         Instantiate(m_TankPrefab, m_Tanks[i].m_SpawnPoint.position, m_Tanks[i].m_SpawnPoint.rotation) as GameObject;

        //  m_Instance.transform.position = m_SpawnPoint.position;
        //   m_Instance.transform.rotation = m_SpawnPoint.rotation;

        //   m_Instance.SetActive(false);
        //   m_Instance.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
