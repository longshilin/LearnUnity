using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    public Transform[] waypoints;
    
    void Start() 
    {
        waypoints = new Transform[transform.childCount];
        int i = 0;
        
        foreach (Transform t in transform)
        {
            waypoints[i++] = t;
        }

        // print all waypoints gameobject name
        foreach (var e in waypoints)
        {
            print(e.name);
        }

    }
}
