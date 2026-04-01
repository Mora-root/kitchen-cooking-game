using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class LoaderCallback : MonoBehaviour
{

    private bool isFirstUpdate = true;


    private void Update()
    {
        if (isFirstUpdate)
        {
            isFirstUpdate = false;

            Loader.LoaderCallBack();
        }
    }

}
