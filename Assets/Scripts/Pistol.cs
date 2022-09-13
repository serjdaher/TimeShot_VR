using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Pistol : MonoBehaviour
{
    [SerializeField] protected float shootingForce;
    [SerializeField] protected Transform bulletSpawn;
    [SerializeField] private float recoilForce;
    [SerializeField] private float lifeTime;

    private Rigidbody rb;

    [SerializeField] private GameObject bulletPrefab;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Shoot()
    {
        //rb.AddRelativeForce(Vector3.back * recoilForce, ForceMode.Impulse);
        GameObject projectileInstance = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        projectileInstance.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * GetShootingForce(), ForceMode.Impulse);
        Destroy(projectileInstance, lifeTime);
    }

    public float GetShootingForce()
    {
        return shootingForce;
    }


}
