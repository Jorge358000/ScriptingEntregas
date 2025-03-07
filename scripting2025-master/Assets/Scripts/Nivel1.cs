using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class Volver : MonoBehaviour
{
    public void Level1(){
        MMSceneLoadingManager.LoadScene("Nivel1");
    }

    public void Menu(){
        MMSceneLoadingManager.LoadScene("Menu");
    }

    public void CerrarNivel(){
        Application.Quit();
        Debug.Log("Juego cerrardo");
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void instrucciones(){
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }
}
