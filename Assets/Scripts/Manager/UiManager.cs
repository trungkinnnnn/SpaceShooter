using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;

    [SerializeField] GameObject gameOverPanel;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
       
    }

    public void ShowPanelGameOver() => gameOverPanel.SetActive(true);

}
