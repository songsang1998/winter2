﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ms : MonoBehaviour
{
    // Start is called before the first frame update

  


    // Update is called once per frame
    public void Exit()
    {

      

            Application.Quit();
#if !UNITY_EDITOR
        System.Diagnostics.Process.GetCurrentProcess().Kill();
#endif

        


    }
}
