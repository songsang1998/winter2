using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiosave : MonoBehaviour
{
    GameObject music;
    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.Find("Canvas").transform.GetChild(5).GetChild(1).gameObject;
        if (PlayerPrefs.HasKey("sound"))
        {
            if (PlayerPrefs.GetInt("sound") == 0)
            {
                music.transform.GetChild(2).gameObject.SetActive(true);
                music.transform.GetChild(1).gameObject.SetActive(false);
                GameObject.Find("Audio Source").GetComponent<AudioSource>().Stop();
            }
            else
            {
                music.transform.GetChild(1).gameObject.SetActive(true);
                music.transform.GetChild(2).gameObject.SetActive(false);
            }
        }
        else
        {
            music.transform.GetChild(1).gameObject.SetActive(true);
            music.transform.GetChild(2).gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    public void offsave()
    {
        PlayerPrefs.SetInt("sound", 0);
        PlayerPrefs.Save();

    }
    public void onsave()
    {
        PlayerPrefs.SetInt("sound", 1);
        PlayerPrefs.Save();
    }
}
