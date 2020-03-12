using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class list : MonoBehaviour
{
    static GameObject mana;
    int movescene;

    // Start is called before the first frame update
    void Start()
    {   
        mana = GameObject.Find("Manager");
        movescene = int.Parse(gameObject.name);
       

    }

    // Update is called once per frame
    public void Click()
    {



        mana.GetComponent<Setting>().stars = false;
        mana.GetComponent<Scenemove>().scenenumber = movescene;
      
        mana.GetComponent<Setting>().SettingStart();
    }
  
}
