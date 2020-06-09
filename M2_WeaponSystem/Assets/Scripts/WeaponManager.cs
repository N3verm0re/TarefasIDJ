using UnityEngine;
using WeaponSystem;

public class WeaponManager : MonoBehaviour
{
    public Camera playerCamera;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
