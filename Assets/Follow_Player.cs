using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine.Utility;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{

    [SerializeField] private Transform player;
    private void LateUpdate()
    {
        Vector3 cameraPos = transform.position;
        cameraPos = player.position;
        transform.position = cameraPos;

    }
}
