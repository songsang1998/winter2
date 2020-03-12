using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSetting : MonoBehaviour
{
    // Start is called before the first frame update

    buttonname dr;
    bool ON=false;
    // Update is called once per frame
    public void Set()
    {
        foreach (Transform c in gameObject.transform)
        {
            ON = false;
            dr = c.GetChild(0).GetComponent<buttonname>();
            for (int i = 0; i<dr.get.Length;i++) {
                if (PlayerPrefs.HasKey("data" + dr.get[i]))
                {
                    if (PlayerPrefs.GetInt("data" + dr.get[i]) == 1)
                    {
                        c.GetChild(0).gameObject.SetActive(true);
                        c.GetChild(1).gameObject.SetActive(false);
                        ON = true;
                        break;
                    }
                    Debug.Log("s");
                }
            }
            if (!ON)
            {
                c.GetChild(1).gameObject.SetActive(true);
                c.GetChild(0).gameObject.SetActive(false);
            }

           
            
        }
    }
}
