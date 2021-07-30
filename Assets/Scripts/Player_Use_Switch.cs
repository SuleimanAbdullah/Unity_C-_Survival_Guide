using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Use_Switch : MonoBehaviour
{
    public int WeaponID;

    void Update()
    {
        switch (WeaponID)
        {
            case 1:
                Debug.Log(" Gun selected");
                break;
            case 2:
                Debug.Log("Knife Selected");
                break;
            case 3:
                Debug.Log("Machine gun Selected");
                break;
        }

    }

}
