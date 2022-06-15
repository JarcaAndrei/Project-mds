using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitGameButton : MonoBehaviour
{
    public void ReturnToMenu(){
        Debug.Log("RETURN TO MENU!");
        
        SceneManager.LoadScene(0);
    }
}