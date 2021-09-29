using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public Waypoints[] levelWaypoints;
    void Start()
    {
        levelWaypoints = Object.FindObjectsOfType<Waypoints>();        
    }
}
