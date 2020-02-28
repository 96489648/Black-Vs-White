using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject []spawnee;
    public void defeat_anim()
    { 
        for (int i = 0; i < spawnee.Length; i++)
        {
            Instantiate(spawnee[i] , transform.position ,Quaternion.identity);
        }     
    }
}
