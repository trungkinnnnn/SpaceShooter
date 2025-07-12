using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFlow : MonoBehaviour
{
    [SerializeField] GameObject panelGameOver;
    [SerializeField] GameObject panelGameWin;

    [SerializeField] PlayerHealth playerHealth;
    [SerializeField] GameObject backGroundMusic;

    private void Start()
    {
        panelGameOver.SetActive(false);
        panelGameWin.SetActive(false);

        playerHealth.onDead += OnGameOver;
    }

    private void Update()
    {
        if(EnemyHealth.enemyLiving <= 0)
        {
            OnGameWin();
        }
    }

    private void OnGameOver()
    {
        panelGameOver.SetActive(true);
        backGroundMusic.SetActive(false);
    }    

    private void OnGameWin()
    {
        panelGameWin.SetActive(true);
        backGroundMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false);
    }
    
}
