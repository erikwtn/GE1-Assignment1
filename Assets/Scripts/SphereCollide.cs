using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollide : MonoBehaviour
{
    [SerializeField] private GameObject blackScreen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            blackScreen.SetActive(true);
        }
    }
}
