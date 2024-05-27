using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candidatos : MonoBehaviour
{
    [SerializeField]    
    private float velocidade = 0.8f;
    [SerializeField]
    private float tempoparadeletar;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        this.transform.Translate(Vector3.up * Random.Range(-0.003f, 0.003f));
    }

    // isso daqui � para deletar o obstaculo,
    // quando sair da camera mas ele deleta no meio da camera,
    // mas se colocar um tempo ele n�o vai deletar na camera e n�o sei como consertar.
    private void OnBecameInvisible()
    {
        Debug.Log("invis�vel");
        Destroy(this.gameObject, tempoparadeletar);
    }
}

