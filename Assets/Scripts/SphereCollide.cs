using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereCollide : MonoBehaviour
{
    [SerializeField] private GameObject blackScreen;
    [SerializeField] private AudioSource source;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            blackScreen.SetActive(true);
            source.Play();
            StartCoroutine(ChangeScene());
        }
    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSecondsRealtime(6f);
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
}
