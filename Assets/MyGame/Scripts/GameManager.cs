using System;
using UnityEngine;
[AddComponentMenu("DangSon/GameManager")]
public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance 
    { 
        get => _instance;   
    }
    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    private int coin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coin = DataManager.DataCoin;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void AddCoin(int amount)
    {
        coin += amount;
        DataManager.DataCoin = coin;
    }

     public int GetCoin()
    {
        return coin;
    }
}
