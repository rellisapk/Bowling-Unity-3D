using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void HowToPlay(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void Skins(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void Back(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void Exit(){
        Application.Quit();
    }
}
