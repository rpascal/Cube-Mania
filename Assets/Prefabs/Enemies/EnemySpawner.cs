using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public BaseEnemy[] enemies;
    public Vector3 spawnValues;

    public BaseGround ground;
    public LayerMask groundLayer;

    public float initialWaitPeriod = 2f;
    public float maxSpawnWait = 2f;
    public float minSpawnWait = 1f;
    public bool isSpawning = true;

    private float GroundLowerX, GroundUpperX, GroundLowerZ, GroundUpperZ;


    void Awake() {
        var groundPositionX = ground.transform.position.x;
        var groundPositionZ = ground.transform.position.z;
        var halfGroundSizeX = ground.transform.localScale.x / 2;
        var halfGroundSizeZ = ground.transform.localScale.z / 2;

        GroundLowerX = groundPositionX - halfGroundSizeX;
        GroundUpperX = groundPositionX + halfGroundSizeX;

        GroundLowerZ = groundPositionZ - halfGroundSizeZ;
        GroundUpperZ = groundPositionZ + halfGroundSizeZ;


        StartCoroutine(spawner());

    }

    void Update() {
    }

    IEnumerator spawner() {
        yield return new WaitForSeconds(initialWaitPeriod);
        while (isSpawning) {
            Instantiate(getRandomEnemy(), getRandomEnemyPosition(), Quaternion.identity, transform);
            yield return new WaitForSeconds(Random.Range(minSpawnWait, maxSpawnWait));
        }
    }

    private BaseEnemy getRandomEnemy() {
        var enemyIndex = Random.Range(0, enemies.Length);
        return enemies[enemyIndex];
    }


    private Vector3 getRandomEnemyPosition() {
        RaycastHit hit;
        float groundHeight = 0f;
        float randomX, randomY, randomZ;
        randomX = Random.Range(GroundLowerX, GroundUpperX);
        randomZ = Random.Range(GroundLowerZ, GroundUpperZ);
        if (Physics.Raycast(new Vector3(randomX, 9999f, randomZ), Vector3.down, out hit, Mathf.Infinity, groundLayer)) {
            groundHeight = hit.point.y;
        }
        randomY = groundHeight;
        return new Vector3(randomX, 2, randomZ);
    }



}
