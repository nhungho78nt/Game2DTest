using System;
using UnityEngine;
[AddComponentMenu("DangSon/DataManager")]
public static class DataManager 
{
  public static int DataCoin
    {
        get=> PlayerPrefs.GetInt(Datakey.DataCoin, 0);
        set=> PlayerPrefs.SetInt(Datakey.DataCoin, value);
    } 
}
