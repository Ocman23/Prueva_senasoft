using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.XR;

public class EnemyController : MonoBehaviour
{
    private NavMeshAgent agent;
    public List<Transform> targetPositions = new List<Transform>();
    public int currPosition;
    public int vueltas;
    public int cantVueltas;
    public bool defeat;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
   
    void Update()
    {
        
        
        
        if (vueltas < cantVueltas)
        {
            if (transform.position.x == targetPositions[currPosition].position.x && transform.position.z == targetPositions[currPosition].position.z)
            {
                currPosition++;
                if (currPosition > targetPositions.Count - 1)
                {
                    currPosition = 0;
                    vueltas++;
                }
            }
            agent.SetDestination(targetPositions[currPosition].position);
        }


    }

    public void EnemyyDefeated()
    {
        if (defeat==true) 
        {
            agent.isStopped = true;
        }
    }
   
}
