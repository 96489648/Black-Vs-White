using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using GameAnalyticsSDK;

public class GameManager : MonoBehaviour
{

    [SerializeField] float timescale;
    public GameObject panel;

    public GameObject currentcheckpoint;
    [SerializeField] GameObject cameraa;
    [SerializeField] GameObject ball;
    [SerializeField] GameObject highscore = null;

    [SerializeField] move move;
    //[SerializeField] score score = null;
    [SerializeField] Transform startpoint;
    [SerializeField] Transform endpoint;
    [SerializeField] Transform playerposition;

    float totaldistance;
    float playerdistance;
    float playerprogress;

    [SerializeField] Slider slider;

    [SerializeField] spawner spawner;
    public static int buildindex;

    void Start()
    {
        Time.timeScale = timescale;
        cameraa = GameObject.FindGameObjectWithTag("MainCamera");
        ball    = GameObject.FindGameObjectWithTag("Player");
        totaldistance = endpoint.position.x - startpoint.position.x;
        buildindex = SceneManager.GetActiveScene().buildIndex;
       /* if (buildindex <= 500)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, Application.version, buildindex.ToString("00000"));
        }
        else
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, Application.version, "endless");
        }  */
    }

    private void Update()
    {
        playerdistance = playerposition.position.x - startpoint.position.x;
        playerprogress = playerdistance / totaldistance ;
        slider.value = playerprogress;
    }

    public void ondeath()
    {
        move.movement = false;
        spawner.defeat_anim(); 
        Invoke("reload", 1);
        /*if (buildindex <= 500)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, Application.version, buildindex.ToString("00000"));
        }
        else
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, Application.version, "endless" , PlayerPrefs.GetInt("high", 0).ToString());
        }   */
    }
    void reload()
    {
        panel.SetActive(true);
    }

    public void continuee()
    {
        cameraa.transform.position = new Vector3(currentcheckpoint.transform.position.x + 3.2f , 0 , -10);
        ball.transform.position = new Vector2(ball.transform.position.x , 1.6f);
        ball.SetActive(true);
        move.movement = true;

       /* if (score != null)
        {
            score.InvokeRepeating("invoke",0,.5f);
            highscore.SetActive(false);
        }*/

    }
 
}
