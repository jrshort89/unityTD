using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Waypoints[] wayArr;
    public float speed = 1f;
    public Enemy enemyPos;

    private Waypoints target;
    private static int waypointIndex = 0;
    private void Start()
    {       
        target = wayArr[waypointIndex];
        enemyPos = Object.FindObjectOfType<Enemy>();
    }

    public static void IncrementIndex()
    {
        waypointIndex++;
    }

    private void Update()
    {
        Vector3 dir = target.transform.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        target = wayArr[waypointIndex];        
    }
}
