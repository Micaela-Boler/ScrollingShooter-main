using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : Armas
{
    [SerializeField] Transform spawnMisil;


    void Update()
    {
        tiempoDeDisparo();
    }


    IEnumerator tiempoDeDisparo()
    {
        yield return new WaitForSeconds(0.5f);
        //Disparar(spawnMisil);
        Debug.Log("Disparo");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BalaJugador"))
        {
            RecibirDaño(vida, daño);

            if (vida >= 0)
                Destroy(gameObject);
        }
    }
}
