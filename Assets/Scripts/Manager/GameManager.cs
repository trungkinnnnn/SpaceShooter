using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OnClickPlayGame()
    {
        SceneManager.LoadScene("Battle");
    }    

    public void OnClickBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }    
    
}
