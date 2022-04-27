using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevel : MonoBehaviour
{
    public static int CurrentLevels;

    public static float timer = 0f;


    //value = number of level in the game minus one
    public static bool[] arr = new bool[5];

    public static bool contactLever = false;
    public static bool contactLever2 = false;
    public static bool contactLever3 = false;
}
