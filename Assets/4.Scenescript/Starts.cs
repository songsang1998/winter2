using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starts : MonoBehaviour
{
   
    static GameObject mana;
    // Start is called before the first frame update
    void Start()
    {
        mana = GameObject.Find("Manager");
        StartCoroutine("Setting");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Setting()
    {


        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
       
      

    }

}
