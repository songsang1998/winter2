using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonname : MonoBehaviour
{
    // Start is called before the first frame update
    public string[] get;
    GameObject ImageList;
    public int number;
    public void Start()
    {
        ImageList = GameObject.Find("ImageList");

    }

    public void Click()
    {
        ImageList.transform.GetChild(number).gameObject.SetActive(true);
    }
    // Update is called once per frame

}
