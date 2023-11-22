using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Bullet bulScript;

    public Transform bulletSpawn;
    public GameObject bullet;
    public GameObject cannonBall;
    public GameObject lazer;
    public float projectileSpeed = 10;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        




        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (((int)bulScript.BulletT & (int)Bullet.EProjectileType.Basic) == (int)Bullet.EProjectileType.Basic)
            {
                var shotFired = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
                shotFired.GetComponent<Rigidbody>().velocity = bulletSpawn.up * projectileSpeed;
            }

            if (((int)bulScript.BulletT & (int)Bullet.EProjectileType.Cannonball) == (int)Bullet.EProjectileType.Cannonball)
            {
                var shotFired = Instantiate(cannonBall, bulletSpawn.position, bulletSpawn.rotation);
                shotFired.GetComponent<Rigidbody>().velocity = bulletSpawn.up * projectileSpeed;
            }

            if (((int)bulScript.BulletT & (int)Bullet.EProjectileType.Lazer) == (int)Bullet.EProjectileType.Lazer)
            {
                var shotFired = Instantiate(lazer, bulletSpawn.position, bulletSpawn.rotation);
                
                shotFired.GetComponent<Rigidbody>().velocity = bulletSpawn.up * projectileSpeed;
                
            }
        }

       


    }
}
