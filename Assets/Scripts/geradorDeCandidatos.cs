using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorDeCandidatos : MonoBehaviour
{

    //Como criar os onst�culos?
    //Onde Criar? Na posi��o de gerador
    //Quando Criar? tempoParaGera
    [SerializeField]
    private float tempoParaGerar = 6f;
    
    private float cronometro;

    [SerializeField]
    private GameObject modeloCandidatos;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloCandidatos, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
