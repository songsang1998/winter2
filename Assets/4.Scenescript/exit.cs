using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
   
    int Click= 0;
    void Update()
    { 

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Click++;
            if (!IsInvoking("Double"))
                Invoke("Double", 0.8f);

        }
        else if (Click == 2)
        {
            CancelInvoke("Double");
            Application.Quit();
        }

    }

    void DoubleClick()
    {
        Click = 0;
    }

}
