using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Up : MonoBehaviour
{
   
    static GameObject mana;
   
    private void Start()
    {
        mana = GameObject.Find("Manager");
    }
    // Start is called before the first frame update
    public void Ups()
    {
        mana.GetComponent<Scenemove>().scenenumber += 1;
        mana.GetComponent<Setting>().SettingStart();
    }
    public void StaUp()
    {
        mana.GetComponent<Setting>().Reversal();
    }

    public void Ending()
    {
        mana.GetComponent<Scenemove>().scenenumber= 1;
        PlayerPrefs.SetInt("Scene", 1);
        SceneManager.LoadScene(0);
    }
        
    

    // Update is called once per frame

}
