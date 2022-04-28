using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActivation : MonoBehaviour
{
    GameObject door;
    private UiGame keyTotal;
    
    public void OpenDoor()
    {
        gameObject.SetActive(false);

    }
    public void CloseDoor()
    {
        gameObject.SetActive(true);

    }
    public void OpenDoor(int keycollect)
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Door");

 //
    }


}
