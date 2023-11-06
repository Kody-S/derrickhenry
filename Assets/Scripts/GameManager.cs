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

    public void ShowcaseMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void TryGameAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void FirstLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }

    public void SecondLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ThirdLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void FourthLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void ReturnFromShowcase(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }

    public void AllTeamsShowcase(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void AFCTeamsShowcase(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void NFCTeamsShowcase(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void ReturnFromAllTeamsShowcase(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void ReturnFromAFCTeamsShowcase(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ReturnFromNFCTeamsShowcase(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void GoToLevelTwo(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 14);
    }

    public void GoToLevelThree(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 16);
    }

    public void GoToLevelFour(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void Bills(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void Dolphins(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void Jets(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    public void Patriots(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

    public void Bengals(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }

    public void Browns(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }

    public void Ravens(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
    }

    public void Steelers(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
    }

    public void Colts(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
    }

    public void Jaguars(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 14);
    }

    public void Texans(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15);
    }

    public void Titans(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 16);
    }

    public void Broncos(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 17);
    }

    public void Chargers(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 18);
    }

    public void Chiefs(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 19);
    }

    public void Raiders(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 20);
    }

    public void Commanders(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 21);
    }

    public void Cowboys(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 22);
    }

    public void Eagles(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 23);
    }

    public void Giants(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 24);
    }

    public void Bears(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 25);
    }

    public void Lions(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 26);
    }

    public void Packers(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 27);
    }

    public void Vikings(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 28);
    }

    public void Buccanners(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 29);
    }

    public void Falcons(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 30);
    }

    public void Panthers(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 31);
    }

    public void Saints(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 32);
    }

    public void SF(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 33);
    }

    public void Cardinals(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 34);
    }

    public void Rams(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 35);
    }

    public void Seahawks(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 36);
    }

    public void ReturnToAllShowcaseFromBills(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

    public void ReturnToAllShowcaseFromDolphins(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }

    public void ReturnToAllShowcaseFromJets(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }

    public void ReturnToAllShowcaseFromPatriots(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }

    public void ReturnToAllShowcaseFromBengals(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }

    public void ReturnToAllShowcaseFromBrowns(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void ReturnToAllShowcaseFromRavens(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }

    public void ReturnToAllShowcaseFromSteelers(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 12);
    }

    public void ReturnToAllShowcaseFromColts(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 13);
    }

    public void ReturnToAllShowcaseFromJaguars(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 14);
    }

    public void ReturnToAllShowcaseFromTexans(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 15);
    }

    public void ReturnToAllShowcaseFromTitans(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 16);
    }

    public void ReturnToAllShowcaseFromBroncos(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 17);
    }

    public void ReturnToAllShowcaseFromChargers(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 18);
    }

    public void ReturnToAllShowcaseFromChiefs(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 19);
    }

    public void ReturnToAllShowcaseFromRaiders(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 20);
    }

    public void ReturnToAllShowcaseFromCommanders(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 21);
    }

    public void ReturnToAllShowcaseFromCowboys(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 22);
    }

    public void ReturnToAllShowcaseFromEagles(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 23);
    }

    public void ReturnToAllShowcaseFromGiants(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 24);
    }

    public void ReturnToAllShowcaseFromBears(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 25);
    }

    public void ReturnToAllShowcaseFromLions(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 26);
    }

    public void ReturnToAllShowcaseFromPackers(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 27);
    }

    public void ReturnToAllShowcaseFromVikings(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 28);
    }

    public void ReturnToAllShowcaseFromBuccaneers(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 29);
    }

    public void ReturnToAllShowcaseFromFalcons(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 30);
    }

    public void ReturnToAllShowcaseFromPanthers(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 31);
    }

    public void ReturnToAllShowcaseFromSaints(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 32);
    }

    public void ReturnToAllShowcaseFrom49ers(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 33);
    }

    public void ReturnToAllShowcaseFromCardinals(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 34);
    }

    public void ReturnToAllShowcaseFromRams(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 35);
    }

    public void ReturnToAllShowcaseFromSeahawks(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 36);
    }

}
