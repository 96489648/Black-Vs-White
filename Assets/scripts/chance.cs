using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class chance : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] GameManager GameManager;
    [SerializeField] GameObject cont;
    [SerializeField] GameObject cont1 = null;
    [SerializeField] GameObject sliderr;
    private void Start()
    {
        slider.value = 0;
        GameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        if (slider.value != 1)
        {
            slider.value += Time.deltaTime * .3f;
        }

        if (slider.value == 1)
        {
            sliderr.SetActive(false);
            cont.SetActive(false);
            cont1.SetActive(false);
        }
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void continuee()
    {
        cont.SetActive(false);
        GameManager.continuee();
        slider.value = 0f;
        cont1.SetActive(true);
       // add.instanceee.showvideo();
    }
    public void continuee1()
    {
        GameManager.continuee();
        sliderr.SetActive(false);
        cont1.SetActive(false);
       // add.instanceee.showvideo();
    }

    public void nextt()
    {
        SceneManager.LoadScene(0);
    }
}
