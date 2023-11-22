using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bullet : MonoBehaviour
{
    public float timeActive = 5f;

    private void Awake()
    {
        Destroy(gameObject, timeActive);
    }


    
    private void OnTriggerEnter(Collider enemy)
    {
        if (enemy.CompareTag("Enemy"))
        {
            Destroy(enemy.gameObject);
            Destroy(gameObject);
        }
        
        

        
    }

    //[Flags] cant do this bc we're not in a namespace i think?

    [Flags]
    public enum EProjectileType
    {
        Basic = 1,
        Cannonball = 2,
        Lazer = 4 
    }

    //private var weaponType : EProjectileType;

    //[field: SerializeField] 
    public EProjectileType BulletT; 
    //{ get; private set; }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Q");
            BulletT = EProjectileType.Basic;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W");
            BulletT = EProjectileType.Cannonball;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E");
            BulletT = EProjectileType.Lazer;
        }
        */
    }
}
