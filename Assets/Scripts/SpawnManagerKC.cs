using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerKC : MonoBehaviour
{
public GameObject enemyPrefab;
    private float spawnRange = 9;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GenerateSpawnPosition (){
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0.81f, spawnPosZ);
        return randomPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn){
        for (int i = 0; i < enemiesToSpawn; i++){
            Instantiate(enemyPrefab, GenerateSpawnPosition(),enemyPrefab.transform.rotation);
        }
    }
}
// new Vector3(0, 0.81f, 6), 
