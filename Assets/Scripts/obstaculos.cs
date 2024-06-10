using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    [SerializeField]
    private float variacaoposicaoy;
    private Vector3 posicaoPassaro;
    private bool pontoBool;
    private UiControle uiController;
    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoposicaoy,variacaoposicaoy));
    }
    private void Start()
    {
       this.posicaoPassaro = GameObject.FindObjectOfType<BirdBehavior>().transform.position;
        this.uiController = GameObject.FindAnyObjectByType<UiControle>();
    }
    void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);

        if (!this.pontoBool && this.transform.position.x < this.posicaoPassaro.x)
        {
            this.uiController.AdicionarPontos();
            this.pontoBool = true;
        }
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
