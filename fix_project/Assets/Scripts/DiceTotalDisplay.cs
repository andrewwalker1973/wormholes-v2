using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceTotalDisplay : MonoBehaviour
{

  DiceRoller theDiceRoller;

    // Start is called before the first frame update
    void Start()
    {
        theDiceRoller = GameObject.FindObjectOfType<DiceRoller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (theDiceRoller.IsDoneRolling == false)
        {
            GetComponent<TMP_Text>().text = "Dice Total =  ?";
        }
        else
        {
            GetComponent<TMP_Text>().text = "Dice Total =  " + theDiceRoller.DiceTotal;
        }
    }
}
