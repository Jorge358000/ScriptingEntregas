using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Colision : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other){
        Creditos();
    }

    public void Creditos(){
        MMSceneLoadingManager.LoadScene("Creditos");
    }
}
