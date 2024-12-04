using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupshpheres : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
