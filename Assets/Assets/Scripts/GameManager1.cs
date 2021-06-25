using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public static GameManager1 instance;
    bool isGameOver = false;
    int score = 0;

    public EnemySpawn enm;
    private void Awake()
    {
        if(instance ==null)
        {
            instance = this;
        }
    }
    public void incrementScore()
    {
        if(!isGameOver)
        {
            score++;
            Debug.Log("Score: " + score);
        }
        else
        {
            enm.stopSpawn();
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
