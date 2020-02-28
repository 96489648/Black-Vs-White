using UnityEngine;
using System.Collections.Generic;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] SpriteRenderer sr;
    [SerializeField] GameManager GameManager;
    [SerializeField] GameObject cameraaa = null;
    [SerializeField] GameObject repeat = null;
   // [SerializeField] score score = null;
    [SerializeField] GameObject highscore = null;


    float bounceforce = 9.5f ;
    float jumpforce = 15;
    float gravity = -9.6f;
    bool  isforce = false;
    
    private void Awake()
    {
        if (MainMenu.currentsprite != null)
        {
            sr.sprite = MainMenu.currentsprite;
        }
    }

    void Update() 
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            negativeforce();       
        }
        if (isforce == true)
        {
            force() ;
        }
    }

    void FixedUpdate() 
    { 
        rb.AddForce (gravity * Vector2.up);
    }

    void force()
    {
        isforce = false;
        rb.velocity = Vector2.up * bounceforce;
    }

    void negativeforce()
    {
        rb.velocity = Vector2.down * jumpforce;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isforce = true;
     
        if (collision.collider.tag == "enemy")
        {
            isforce = false;
            gameObject.SetActive(false);

          /*  if (score != null)
            {
                score.CancelInvoke();
                score.highscore.text = PlayerPrefs.GetInt("high", 0).ToString();
                highscore.SetActive(true);
                if (score.currentscore > PlayerPrefs.GetInt("high", 0))
                {
                    PlayerPrefs.SetInt("high", score.currentscore);
                    score.highscore.text = PlayerPrefs.GetInt("high", 0).ToString();
                }
            }*/

            GameManager.ondeath();
        }
    }

    void OnTriggerEnter2D (Collider2D collision)
    {
       
        if (collision.CompareTag("black"))
        { 
            sr.color = Color.black;
            GameManager.currentcheckpoint = collision.gameObject;
        }
        if (collision.CompareTag("white"))
        {
            sr.color = Color.white;
            GameManager.currentcheckpoint = collision.gameObject;
        }
        if (collision.CompareTag("slow"))
        {
            Time.timeScale = 0.8f;
        }

        if (collision.CompareTag("fast"))
        {
            Time.timeScale = 0.98f;
        }

        if (collision.CompareTag("repeat"))
        {
            cameraaa.transform.position = new Vector3(repeat.transform.position.x + 3f, 0, -10);
        }  
    }
}


