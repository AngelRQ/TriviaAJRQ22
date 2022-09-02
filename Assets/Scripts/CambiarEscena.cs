using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void CambiarEscenaClick (string sceneName){
        Debug.Log("CAMBIANDO ESCENA: " + sceneName);
        StartCoroutine(retrasoEscena(sceneName));
    }   //FIN CambiarEscenaClick

    public void SalirJuego(){
        Debug.Log("SALIENDO DEL JUEGO");
        Application.Quit();
    }// FIN salirJuego


    IEnumerator retrasoEscena(string sceneName)
    {
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene(sceneName);
    }

}// FIN DE LA CLASE
