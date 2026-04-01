using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

[CreateAssetMenu()]
public class RecipeSO : ScriptableObject
{

    public List<KitchenObjectSO> kitchenObjectSOList;
    public string recipeName;

}
