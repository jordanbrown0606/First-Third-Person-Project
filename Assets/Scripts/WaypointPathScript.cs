using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPathScript : MonoBehaviour
{
    public Transform GetWaypoint(int waypointIndex)
    { 
        return transform.GetChild(waypointIndex);
    }

    public int GetNextWaypoint(int currentWaypointIndex)
    {
        int nextWaypointIndex = currentWaypointIndex + 1;

        if (nextWaypointIndex == transform.childCount)
        {
            nextWaypointIndex = 0;
        }

        return nextWaypointIndex;
    }
}
