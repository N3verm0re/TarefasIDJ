using System.Collections.Generic;
using UnityEngine;
using WeaponSystem;

public class WeaponManager : MonoBehaviour
{
    public int selectedWeapon = 0;
    public Dictionary<string, Manufacturer> manufacturerList;
    public string ManufacturerJsonPath;

    private void Start()
    {
        //Load manufacturerList
        //manufacturerList

        //Load Weapons
        SelectWeapon();
    }

    void Update()
    {
        /*if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }*/

        //Weapon Switching
        int previousWeapon = selectedWeapon;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedWeapon >= transform.childCount - 1) { selectedWeapon = 0; }
            else { selectedWeapon++; }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0) { selectedWeapon = transform.childCount - 1; }
            else { selectedWeapon--; }
        }

        if(previousWeapon != selectedWeapon)
        {
            SelectWeapon();
        }
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if(i == selectedWeapon) { weapon.gameObject.SetActive(true); }
            else { weapon.gameObject.SetActive(false); }
            i++;
        }
    }
}
