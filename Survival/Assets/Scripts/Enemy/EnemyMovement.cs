using UnityEngine;
using System.Collections;
using System;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    NavMeshAgent nav;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        playerHealth = player.GetComponent <PlayerHealth> ();
        var temp = GetComponent<EnemyAttack>();
        nav = GetComponent <NavMeshAgent> ();
    }


    void Update ()
    {
        enemyHealth = GetComponent<EnemyHealth>();
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            try
            {
                nav.SetDestination(player.position);
            }
            catch(Exception ex)
            {
                var a = ex;
            }
        }
        else
        {
            nav.enabled = false;
        }
    }
}
