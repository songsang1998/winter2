using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public void Set()
    {
        foreach (Transform c in gameObject.transform) {

            if (PlayerPrefs.HasKey("data" + c.name))
            {
                if (PlayerPrefs.GetInt("data" + c.name) == 1)
                {
                   c.gameObject.SetActive(true);
                }
            }
            else
            {
                c.gameObject.SetActive(false);
            }
        }
    }
}
