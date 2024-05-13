using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GerarObstaculos : MonoBehaviour
{
    // como criar obstaculos?
    // Onde criar? Na posição do gerador
    // quando criar? Tempo

    [SerializeField]
    private float TempoParaGerar = 5f;
    private float Cronometro;
    [SerializeField]
    private GameObject modeloObstaculo;
    private void Awake()
    {
        this.Cronometro = TempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.Cronometro -= Time.deltaTime;
        if(this.Cronometro < 0)
        {
            GameObject.Instantiate(this.modeloObstaculo,this.transform.position, Quaternion.identity);
            this.Cronometro = TempoParaGerar;
        }
    }
}
