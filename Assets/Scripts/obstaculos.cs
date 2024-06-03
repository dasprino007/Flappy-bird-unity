using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    [SerializeField]
    private float variacaoposicaoy;
    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoposicaoy,variacaoposicaoy));
    }
    void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.destruir();
    }

    private void destruir()
    {
        Destroy(this.gameObject);
    }
}
