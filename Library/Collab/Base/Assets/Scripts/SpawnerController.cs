using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject goodMob;
    public GameObject badMob;
    public float randX;
    public float randY;
    private int numGoodMobs = 1;
    private int numBadMobs = 2;
    public Vector2 spawnPoint;
    int currentBadGuys = GameObject.FindGameObjectsWithTag("Bad Guy").Length;
    int badGuysLeft;
    public HealthBar health;

    void Start()
    {        
        StartCoroutine(SpawnTimer());
        badGuysLeft = 20;
        health.SetMaxHealth(badGuysLeft);
    }

    public IEnumerator SpawnTimer()
    {
        for (int i = 0; i < numGoodMobs; i++)
        {
            randX = Random.Range(-5.3f, 5.3f);
            randY = Random.Range(-2.5f, 2.5f);
            spawnPoint.Set(randX, randY);
            Instantiate(goodMob, spawnPoint, Quaternion.identity);
        }
        for (int i = 0; i < numBadMobs; i++)
        {
            randX = Random.Range(-5.3f, 5.3f);
            randY = Random.Range(-2.5f, 2.5f);
            spawnPoint.Set(randX, randY);
            Instantiate(badMob, spawnPoint, Quaternion.identity);
        }
        yield return new WaitForSeconds(3);
        StartCoroutine(SpawnTimer());
    }

    void FixedUpdate()
    {
        badGuysLeft = 20 - currentBadGuys;
        health.SetHealth(badGuysLeft);
    }
}
