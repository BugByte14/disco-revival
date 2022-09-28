using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;
    public Animator anim;
    private bool enemyAttacked;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        OnTriggerEnter(player.GetComponent<Collider>());
        /*if (IsInAttackRange(enemy, player) && Input.GetKey("E"))
        {
            Destroy(enemy, 2);
        }*/
    }

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Destroy(enemy);
        }
    }

    /*void OnCollisionEnter2D(Collision2D col)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Destroy(enemy, 2);
        }
    }*/

    public static bool IsInAttackRange(GameObject enemy, GameObject player)
    {
        if (player.GetComponent<CircleCollider2D>().IsTouching(enemy.GetComponent<BoxCollider2D>()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
