using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class Volver : MonoBehaviour
{
    [SerializeField] private GameObject dif;

    private void Start()
    {
        dif.SetActive(false);
    }
    public void Level1(){
        dif.SetActive(true);
        
    }

    public void Menu(){
        MMSceneLoadingManager.LoadScene("Menu");
    }

    public void CerrarNivel(){
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void instrucciones(){
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }
}
