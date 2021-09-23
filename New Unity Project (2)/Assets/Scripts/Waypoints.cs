using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Waypoints[] waypoints;

    private void Start()
    {
        waypoints = Object.FindObjectsOfType<Waypoints>();        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        Enemy.IncrementIndex();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
    }
}