using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{
    public void casa1(){
        SceneManager.LoadScene("Casa1", LoadSceneMode.Single);
    }
    public void casa2(){SceneManager.LoadScene("Casa2", LoadSceneMode.Single);}
    public void casa3(){SceneManager.LoadScene("Casa3", LoadSceneMode.Single);}
    public void casa4(){SceneManager.LoadScene("Casa4", LoadSceneMode.Single);}
    public void casa5(){SceneManager.LoadScene("Casa5", LoadSceneMode.Single);}

    
}
