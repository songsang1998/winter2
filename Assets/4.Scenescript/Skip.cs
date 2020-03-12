using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void Skips()
    {
        GameObject.Find("Manager").GetComponent<Setting>().skip = true;
    }
}
