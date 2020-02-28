using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using GameAnalyticsSDK;

public class levelcomplete : MonoBehaviour
{
    [SerializeField] GameObject congrats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            congrats.SetActive(true);
            /* GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, Application.version, GameManager.buildindex.ToString("00000"));  
             Invoke("main", 1f);
             add.instanceee.showadd();*/
            Invoke("main", 1f);
        }     
    }
    void main()
    {
        savedata.savelevel();
        
        SceneManager.LoadScene(0);  
    }
}
