using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IKDUAssignment2 : MonoBehaviour
{
    public string [] Weekdays;
    public int currentDay;
    void IfElsePlanner()
    {
        if(Weekdays[currentDay] == "Monday")
        {
            Debug.Log(" I go to Cheerleading-training.");
        }
        else if(Weekdays[currentDay] == "Tuesday")
        {
            Debug.Log(" I usually have a lecture at university.");
        }
         else if(Weekdays[currentDay] == "Wednesday")
        {
            Debug.Log(" I usually study and recap last weeks lectures.");
        }
         else if(Weekdays[currentDay] == "Thursday")
        {
            Debug.Log(" I go to a family activity in the evening.");
        }
         else if(Weekdays[currentDay] == "Friday")
        {
            Debug.Log(" I usually sleep in so I can study more efficiently.");
        }
         else if(Weekdays[currentDay] == "Saturday")
        {
            Debug.Log(" I clean my apartment because why not?");
        }
         else if(Weekdays[currentDay] == "Sunday")
        {
            Debug.Log(" I go to Church");
        }
    }
    void Start()
    {
        // IfElsePlanner();
        SwitchPlanner();   
    }
    
    void SwitchPlanner()
    {
        switch(currentDay)
        {
            case 0:
            Debug.Log(" I go to Cheerleading-training.");
            break;

            case 1:
            Debug.Log(" I usually have a lecture at university.");
            break;

            case 2:
            Debug.Log(" I usually study and recap last weeks lectures.");
            break;

            case 3:
            Debug.Log(" I go to a family activity in the evening.");
            break;

            case 4:
            Debug.Log(" I usually sleep in so I can study more efficiently.");
            break;

            case 5:
            Debug.Log(" I clean my apartment because why not?");
            break;

            case 6:
           Debug.Log(" I go to Church");
            break;
        }
    }
}
