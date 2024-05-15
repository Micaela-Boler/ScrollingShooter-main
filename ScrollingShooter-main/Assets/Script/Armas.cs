using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Armas : MonoBehaviour
{
    [SerializeField] Bullet bulletPrefab;

    [SerializeField] protected int vida;

    [SerializeField] protected int daño;  



    protected virtual void Disparar(Transform spawn)
    {
        Bullet projectile = Instantiate(bulletPrefab, spawn.position, transform.rotation);
        projectile.LaunchBullet(transform.up);
    }




    //recibir daño (jugador, obstaculo, enemigo)

    protected virtual void RecibirDaño(int vida, int daño)
    {
        vida -= daño;
    }

}