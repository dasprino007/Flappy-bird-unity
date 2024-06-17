using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iabehavior : MonoBehaviour
{
    Rigidbody2D fisica;
    private Vector3 Obstaculopos;
    [SerializeField]
    private float TempoParaimpulsionar = 1f;
    private float Cronometro;
    [SerializeField]
    private float limiteposobsx = 1f;
    [SerializeField]
    private float impulse = 3.0f;
    [SerializeField]
    private float ChegarY = 0f;
    private bool Impulartime = false;
    // Start is called before the first frame update

    private void Awake()
    {
        this.Cronometro = TempoParaimpulsionar;
        this.fisica = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Cronometro -= Time.deltaTime;
        if (Cronometro < 0)
        {
            Impulartime = false;
            Cronometro = TempoParaimpulsionar;
        }

        acharObstaculo();

        if (GameObject.Find("Pos-obs-y") != null && (this.transform.position.y < Obstaculopos.y && Impulartime == false)
        {
            impulsionar();
            Debug.Log("impulsionar para o obstaculo");
            Impulartime = true;
        }
        else if (this.transform.position.y < ChegarY && Impulartime == false)
        {
            impulsionar();
            Impulartime = true;
        }


    }

    void acharObstaculo()
    {
        if (GameObject.Find("Pos-obs-y") != null)
        {
            Debug.Log("obstaculo na pos 0");
            Obstaculopos = GameObject.Find("Pos-obs-y").transform.position;
        }
        else
        {
            Debug.Log("não existe");
        }
    }
    void impulsionar()
    {
        fisica.AddForce(Vector2.up * impulse, ForceMode2D.Impulse);
    }
}
