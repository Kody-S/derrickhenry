using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.UI;


public class GameManager : MonoBehaviour
{
    PlayerController playerController;
    private float spawnRate = 1.0f;
    public List<GameObject> collectables;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCollectables());
        isGameActive = true;
    }

    public void GameOver(){
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
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
        while (isGameActive){
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, collectables.Count);
            Instantiate(collectables[index]);
        }
    }

    public void HomeScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ReturnHomeFromWin(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    
    public void StartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void SettingsScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void TryGameAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void FirstLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }

}
