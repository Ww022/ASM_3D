using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MyEnemy : MonoBehaviour
{
    public float distance;
    public Transform Player;
    public NavMeshAgent navMeshAgent;
    private void Start()
    {
        
    }
    private void Update()
    {
        distance = Vector3.Distance(this.transform.position, Player.position);
        
        if (distance < 7.5)
        {
            navMeshAgent.destination = Player.position;
        }
    }
}

