using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class ResetStaticDataManager : MonoBehaviour
{

    private void Awake()
    {
        CuttingCounter.ResetStaticData();
        BaseCounter.ResetStaticData();
        TrashCounter.ResetStaticData();
    }

}
