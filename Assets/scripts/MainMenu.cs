using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using GameAnalyticsSDK;

public class MainMenu : MonoBehaviour
{
    public static int index ;
    [SerializeField] Sprite[] characters;
    public static Sprite currentsprite;
    public Text levelname;
    [SerializeField] GameObject[] images;

    private void Awake()
    {   
        Application.targetFrameRate = 60;
        index = savedata.loadlevel();
        levelname.text = "Challenge " + index.ToString();
        currentsprite = characters[savedata.loadcharacter()];
        images[savedata.loadcharacter()].SetActive(true);
  
    }
    public void challenges()
    {
        SceneManager.LoadScene(index);
    }

    public void indexx(int indexxx)
    {
        SceneManager.LoadScene(indexxx);
    }

    public void character0(int charnumber)
    {
        savedata.savecharacter(charnumber);
        currentsprite = characters [savedata.loadcharacter()] ;
    }
}
