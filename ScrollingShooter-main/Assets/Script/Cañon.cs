using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Cañon : Armas
{

    [Header("SPAWN DE BALAS")]

    [SerializeField] GameObject spawnSecundario;

    [SerializeField] GameObject spawnSecundarioA;

    [SerializeField] Transform spawnPrincipal;

    [SerializeField] bool disparoCooldown;

    [Header("VIDA")]
    public GameManager gameManager;


    [Header("CAMARA")]
    [SerializeField] Camera cam;



    private void Start()
    {
        disparoCooldown = true;
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0) && disparoCooldown == true)
            StartCoroutine(DispararCooldown(spawnPrincipal));
    }



    IEnumerator DispararCooldown(Transform spawn)
    {
        Disparar(spawn);
        disparoCooldown = false;

        yield return new WaitForSeconds(0.5f);

        disparoCooldown = true;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BalaEnemiga"))
        {
            RecibirDaño(vida, daño);

            gameManager.CambiarCorazon(vida);


            if (vida >= 0)
                gameManager.CambiarEscena(0);
        }
    }
}


