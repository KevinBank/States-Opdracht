using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States : MonoBehaviour
{
    [SerializeField] private GameObject player; //Player
    [SerializeField] private GameObject enemy; //Enemy
    [SerializeField] private GameObject[] targets;
    [SerializeField] private float speed;
    private int randomTarget;
    private float distanceToTarget;
    private float distancePlayerEnemy;
    private bool playerIsInFollowZone = false;
    private bool playerIsInAttackZone = false;

    private void Awake()
    {
        enemy.transform.LookAt(targets[1].transform.position);
        randomTarget = Random.Range(0, 5);
        distanceToTarget = Vector3.Distance(enemy.transform.position, targets[randomTarget].transform.position);
    }

    private void Update()
    {
        enemy.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        distancePlayerEnemy = Vector3.Distance(enemy.transform.position, player.transform.position);
        if (distancePlayerEnemy >= 5 && distancePlayerEnemy <= 10)
        {
            Follow();
        }
        else if (distancePlayerEnemy >= 1 && distancePlayerEnemy < 5)
        {
            Attack();
        }
        else
        {
            Patrol();
        }
        
    }

    private void Attack()
    {
        Debug.Log("hak");
    }

    private void Follow()
    {
        enemy.transform.LookAt(player.transform.position);
    }

    private void Patrol()
    {
        distanceToTarget = Vector3.Distance(enemy.transform.position, targets[randomTarget].transform.position);
        enemy.transform.LookAt(targets[randomTarget].transform.position);
        if (distanceToTarget >= 0 && distanceToTarget < 2)
        {
            randomTarget = Random.Range(0, 5);
            Debug.Log(randomTarget);
            distanceToTarget = Vector3.Distance(enemy.transform.position, targets[randomTarget].transform.position);
        }

       /* if (targets[1].transform.position.x - enemy.transform.position.x > 2 && goToA)
        {
            Debug.Log("Go to B");
            enemy.transform.LookAt(targets[2].transform.position);
            goToA = false;
        }

        if (enemy.transform.position.x - targets[2].transform.position.x > 2 && !goToA)
        {
            Debug.Log("Go to A");
            enemy.transform.LookAt(targets[1].transform.position);
            goToA = true;
        }
        */
    }
}