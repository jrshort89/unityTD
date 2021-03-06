using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Waypoints[] levelWaypoints;
    Level currentLevel;
    public float speed = 1f;
    public Enemy enemyPos;
    public static int wayArrLength;

    private Waypoints target;
    public int waypointIndex = 1;
    private void Start()
    {
        currentLevel = Object.FindObjectOfType<Level>();
        levelWaypoints = currentLevel.levelWaypoints;
        target = levelWaypoints[waypointIndex];
        enemyPos = Object.FindObjectOfType<Enemy>();
        wayArrLength = currentLevel.levelWaypoints.Length;
    }

    public void IncrementIndex()
    {
        if (wayArrLength - 1 > waypointIndex)
        {
            waypointIndex++;          
        } else
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
            IncrementIndex();
    }

    private void Update()
    {
        Vector3 dir = target.transform.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        target = levelWaypoints[waypointIndex];        
    }
}
