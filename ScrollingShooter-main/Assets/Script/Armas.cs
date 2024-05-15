using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Armas : MonoBehaviour
{
    [SerializeField] Bullet bulletPrefab;

    [SerializeField] protected int vida;

    [SerializeField] protected int da�o;  



    protected virtual void Disparar(Transform spawn)
    {
        Bullet projectile = Instantiate(bulletPrefab, spawn.position, transform.rotation);
        projectile.LaunchBullet(transform.up);
    }




    //recibir da�o (jugador, obstaculo, enemigo)

    protected virtual void RecibirDa�o(int vida, int da�o)
    {
        vida -= da�o;
    }

}