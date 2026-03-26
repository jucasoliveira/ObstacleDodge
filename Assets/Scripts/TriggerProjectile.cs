using System.Collections.Generic;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{

    [SerializeField] private List<GameObject> projectile;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject proj in projectile)
            {
                proj.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
