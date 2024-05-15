using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] List<GameObject> corazones = new List<GameObject>();
    [SerializeField] Sprite corazonDesactivado;



    public void CambiarCorazon(int indice)
    {
        Image imagenCorazon = corazones[indice].GetComponent<Image>();
        imagenCorazon.sprite = corazonDesactivado;
    }



    public void CambiarEscena(int escena)
    {
        SceneManager.LoadScene(escena);
    }

}
