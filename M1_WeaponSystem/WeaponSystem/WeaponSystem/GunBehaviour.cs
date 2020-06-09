using UnityEngine;
using System.Collections;
using System;

public class GunBehaviour
{
    public Camera playerCamera;
    (bool, RaycastHit) Shoot()
    {
        RaycastHit hit;
        return (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit), hit);
    }

    IEnumerator Reload(double reloadSpeed, double currentAmmo, double maxAmmoCount)
    {
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(Convert.ToSingle(reloadSpeed));
        currentAmmo = maxAmmoCount;
    }
}
