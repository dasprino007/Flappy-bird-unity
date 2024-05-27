using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    [SerializeField]
    private float variacaoposicaoy;
    [SerializeField]
    private float tempoparadeletar;
    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoposicaoy,variacaoposicaoy));
    }
    void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
    private void OnBecameVisible() => Debug.Log("Vis�vel");

    // isso daqui � para deletar o obstaculo,
    // quando sair da camera mas ele deleta no meio da camera,
    // mas se colocar um tempo ele n�o vai deletar na camera e n�o sei como consertar.
    private void OnBecameInvisible()
    {
        Debug.Log("invis�vel");
        Destroy(this.gameObject, tempoparadeletar);
    }
}
