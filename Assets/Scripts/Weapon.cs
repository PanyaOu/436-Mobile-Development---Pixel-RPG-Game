using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform firePoint;

    public void Fire(){
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void OnButtonPressed(){
        Fire();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
