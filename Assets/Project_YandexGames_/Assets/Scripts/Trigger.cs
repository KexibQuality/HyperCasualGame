using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using LessonGameSystem.Game;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    [SerializeField] private GameObject root;
    private CoinManager coinManager;
    

    private void LateUpdate()
    {
        root.transform.Rotate(0,rotationSpeed*Time.deltaTime,0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(root);
    }
}
