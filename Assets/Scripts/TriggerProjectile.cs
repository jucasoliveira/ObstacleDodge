using System.Collections.Generic;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{

    [SerializeField] GameObject projectile;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            projectile.SetActive(true);
            Destroy(gameObject);
        }
    }
}
