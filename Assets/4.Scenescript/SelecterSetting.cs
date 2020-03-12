using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelecterSetting : MonoBehaviour
{
    public Text maintext;
    public int textnumber;
    static GameObject mana;

    // Start is called before the first frame update
    public void Start()
    {
        mana = GameObject.Find("Manager");
    }
    public void Textsetting(int a)
    {
        textnumber = a;
        maintext.text = Selects.instance.Set(textnumber);
    }
    // Update is called once per frame
    public void Move()
    {
        mana.GetComponent<Scenemove>().scenenumber = Selects.instance.MoveSet(textnumber);
        mana.GetComponent<Setting>().SettingStart();
    }
}
