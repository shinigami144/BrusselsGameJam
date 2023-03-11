using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockWaypoints : MonoBehaviour
{
    public GameObject [] waypoints;

    private void OnTriggerEnter(Collider other){
        switch (other.name){
            case "Checkpoint":
                waypoints[0].GetComponent<WayPointScript>().lockWayPoint = false;
                
                
            break;
        }
    }
}
