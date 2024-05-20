using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class chaoBehavior : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.9f;

    private Vector3 posi��oInicial;
    private float tamanhoImg;
    private float tamanhoReal;

    private void Awake()
    {
        this.posi��oInicial = this.transform.position;
        this.tamanhoImg = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoReal = escala * this.tamanhoImg;
    }

    // Update is called once per frame
    private void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoReal);
        this.transform.position = this.posi��oInicial + Vector3.left * deslocamento;
    }
}
