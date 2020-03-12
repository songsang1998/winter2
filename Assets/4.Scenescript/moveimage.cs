using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class moveimage : MonoBehaviour
{
   
  
    static GameObject mana;
    public int movenumber;
    // Start is called before the first frame update
    private void Start()
    {
        mana = GameObject.Find("Manager");
    }

    // Update is called once per frame
    public void Move()
    {
        mana.GetComponent<Scenemove>().scenenumber = movenumber;
        mana.GetComponent<Setting>().SettingStart();
    }
}
