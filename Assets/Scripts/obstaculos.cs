using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
