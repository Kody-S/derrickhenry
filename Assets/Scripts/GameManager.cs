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

    public void LevelSelect(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 80);
    }

    public void GoToWildCardFromLevelSelect(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 86);
    }

    public void GoToDivisionalRoundFromLevelSelect(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 83);
    }

    public void GoToConferenceChampionshipFromLevelSelect(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 82);
    }

    public void GoToSuperBowlFromLevelSelect(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 81);
    }

    public void ReturnFromLevelSelect(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 80);
    }
    
    public void ReturnFromLose1(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void ReturnFromLose2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 77);
    }

    public void ReturnFromLose3(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 78);
    }

    public void ReturnFromLose4(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 79);
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void TryGameAgain2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene(). buildIndex - 80);
    }

    public void TryGameAgain3(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 80);
    }

    public void TryGameAgain4(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 80);
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

// GO TO THE TEAMS FROM ALL TEAMS SHOWCASE //
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


// RETURN FROM ALL TEAMS SHOWCASE //
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

// GO TO TEAMS FROM AFC SHOWCASE //

public void GoToBillsAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 38);
}

public void GoToDolphinsAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 39);
}

public void GoToJetsAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 40);
}

public void GoToPatriotsAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 41);
}

public void GoToBengalsAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 42);
}

public void GoToBrownsAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 43);
}

public void GoToRavensAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 44);
}

public void GoToSteelersAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 45);
}

public void GoToColtsAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 46);
}

public void GoToJaguarsAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 47);
}

public void GoToTexansAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 48);
}

public void GoToTitansAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 49);
}

public void GoToBroncosAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 50);
}

public void GoToChargersAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 51);
}

public void GoToChiefsAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 52);
}

public void GoToRaidersAFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 53);
}

// GO TO TEAMS FROM NFC SHOWCASE //

public void GoToCommandersNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 52);
}

public void GoToCowboysNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 53);
}

public void GoToEaglesNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 54);
}

public void GoToGiantsNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 55);
}

public void GoToBearsNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 56);
}

public void GoToLionsNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 57);
}

public void GoToPackersNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 58);
}

public void GoToVikingsNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 59);
}

public void GoToBuccaneersNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 60);
}

public void GoToFalconsNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 61);
}

public void GoToPanthersNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 62);
}

public void GoToSaintsNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 63);
}

public void GoTo49ersNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 64);
}

public void GoToCardinalsNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 65);
}

public void GoToRamsNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 66);
}

public void GoToSeahawksNFC(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 67);
}

// RETURN TO THE AFC SHOWCASE FROM TEAMS //
public void ReturnToAFCFromBills(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 38);
}

public void ReturnToAFCFromDolphins(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 39);
}

public void ReturnToAFCFromJets(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 40);
}

public void ReturnToAFCFromPatriots(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 41);
}

public void ReturnToAFCFromBengals(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 42);
}

public void ReturnToAFCFromBrowns(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 43);
}

public void ReturnToAFCFromRavens(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 44);
}

public void ReturnToAFCFromSteelers(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 45);
}

public void ReturnToAFCFromColts(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 46);
}

public void ReturnToAFCFromJaguars(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 47);
}

public void ReturnToAFCFromTexans(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 48);
}

public void ReturnToAFCFromTitans(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 49);
}

public void ReturnToAFCFromBroncos(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 50);
}

public void ReturnToAFCFromChargers(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 51);
}

public void ReturnToAFCFromChiefs(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 52);
}

public void ReturnToAFCFromRaiders(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 53);
}


// RETURN TO THE NFC SHOWCASE FROM TEAMS //
public void ReturnToNFCFromCommanders(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 52);
}

public void ReturnToNFCFromCowboys(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 53);
}

public void ReturnToNFCFromEagles(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 54);
}

public void ReturnToNFCFromGiants(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 55);
}

public void ReturnToNFCFromBears(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 56);
}

public void ReturnToNFCFromLions(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 57);
}

public void ReturnToNFCFromPackers(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 58);
}

public void ReturnToNFCFromVikings(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 59);
}

public void ReturnToNFCFromBuccaneers(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 60);
}

public void ReturnToNFCFromFalcons(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 61);
}

public void ReturnToNFCFromPanthers(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 62);
}

public void ReturnToNFCFromSaints(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 63);
}

public void ReturnToNFCFrom49ers(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 64);
}

public void ReturnToNFCFromCardinals(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 65);
}

public void ReturnToNFCFromRams(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 66);
}

public void ReturnToNFCFromSeahawks(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 67);
}


}
