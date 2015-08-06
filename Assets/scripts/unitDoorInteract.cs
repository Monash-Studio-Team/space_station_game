﻿using UnityEngine;
using System.Collections;

public class unitDoorInteract : MonoBehaviour 
{
    public GameObject door;

    //Function that tells the unit to open the door that was passed as a parameter
    public void openDoor(GameObject door)
    {
        if (!door.GetComponent<Door>().IsDoorOpen())
        {
            door.GetComponent<Door>().UnitUsingDoor = true;
        }

    }
    //Function that tells the unit to close the door that was passed as a parameter
    public void closeDoor(GameObject door)
    {
        door.GetComponent<Door>().UnitUsingDoor = true;
    }


}
