﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public GameObject player;
    private static Vector3 playerPos;

    public static Vector3 PlayerPos { get => playerPos; set => playerPos = value; }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        PlayerPos = player.transform.position;
    }
}
