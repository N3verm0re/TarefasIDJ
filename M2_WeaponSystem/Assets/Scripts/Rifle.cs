using System;
using UnityEngine;
using WeaponSystem;

public class Rifle : MonoBehaviour
{
    public GunBehaviour controller;
    public Camera PlayerCamera;
    public AssaultRifle info;
    void Start()
    {
        controller.playerCamera = PlayerCamera;
        //info = new AssaultRifle();
    }

    void Update()
    {
        if (info.IsAutomatic)
        {
            if (Input.GetButton("Fire1"))
            {
                RaycastHit hit;
                bool hitSuccess;
                (hitSuccess, hit) = controller.Shoot();

                if (hitSuccess)
                {
                    if (hit.transform.CompareTag("Target"))
                    {
                        TargetBehaviour target = hit.transform.GetComponent<TargetBehaviour>();
                        target.TakeDamage(Convert.ToSingle(info.Damage));
                    }
                }
            }
        }
    }
}
