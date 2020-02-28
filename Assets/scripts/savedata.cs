using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;
using UnityEngine.UI;

public static class savedata
{

    #region  Save $ Load Level
    public static void savelevel()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/level.aaa");

        progresslevel data = new progresslevel();
        data.index = SceneManager.GetActiveScene().buildIndex + 1;
 
        bf.Serialize(file, data);
        file.Close();
    }

    public static int loadlevel()
    {

        if (File.Exists(Application.persistentDataPath + "/level.aaa"))
        {
            FileStream file = File.Open(Application.persistentDataPath + "/level.aaa", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            progresslevel data = (progresslevel)bf.Deserialize(file);
            file.Close();
            return data.index;

        }
        else
        {
            return 1;
        }
    }
    #endregion
    
    #region Save $ Load Character

    public static void savecharacter( int character_no)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file1 = File.Create(Application.persistentDataPath + "/level.char");

        characterchoice data = new characterchoice();
        data.index = character_no;

        bf.Serialize(file1, data);
        file1.Close();
    }

    public static int loadcharacter()
    {
        if (File.Exists(Application.persistentDataPath + "/level.char"))
        {
            FileStream file1 = File.Open(Application.persistentDataPath + "/level.char", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            characterchoice data = (characterchoice)bf.Deserialize(file1);
            file1.Close();
            return data.index;

        }
        else
        {
            return 0;
        }
    }
    #endregion
}

[Serializable]
class progresslevel
{
    public int index; 
}

[Serializable]
class characterchoice
{
    public int index;
}
