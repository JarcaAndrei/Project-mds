using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void LevelOne(){
        SceneManager.LoadScene(1);
    }

    public void LevelTwo(){
        SceneManager.LoadScene(2);
    }

    public void QuitGame(){
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
