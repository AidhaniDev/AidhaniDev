//AidhaniDev2022 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    PhotonView view;

    void OnCollisionEnter2D(Collision2D collision)
    {
           GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
           Destroy(effect, 5f); // this will destory the hit effect after 5 seconds
           Destroy(gameObject); //this will destroy the bullet when it collides with an object
       // Might add for to here in the future! 
    }
}
