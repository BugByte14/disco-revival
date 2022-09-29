using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{
    bool Killem;
    GameObject enemy;

    void Update()
    {
        if(Input.GetKey(KeyCode.E) && Killem == true)
        {
            Destroy(enemy);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bad Guy")
        {
            enemy = other.gameObject;
            Killem = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bad Guy")
        {
            Killem = false;
        }
    }
}
