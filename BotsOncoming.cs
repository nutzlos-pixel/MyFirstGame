using UnityEngine;
using System;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Random = UnityEngine.Random;

public class BotsOncoming : MonoBehaviour
{

    private float speedBot = 12.0f;
    private float offsetSpeed = 1.0f;
    private float speedBotRandom;
    void Start()
    {
        speedBotRandom = Random.Range(speedBot - offsetSpeed, speedBot + offsetSpeed);
    }

    void LateUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speedBotRandom);
    }
}
