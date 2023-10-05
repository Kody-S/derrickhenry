using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    PlayerController playerController;
    private float spawnRate = 1.0f;
    public List<GameObject> collectables;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCollectables());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PowerupCountdownRoutine(){
        yield return new WaitForSeconds(5);
        bool hasGatorade = false;
        bool hasPepsi = false;
    }
    IEnumerator SpawnCollectables(){
        while (true){
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, collectables.Count);
            Instantiate(collectables[index]);
        }
    }
}
