using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class BirdBehavior : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    private float impulse = 3.0f;

    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.impulsionar();
            Debug.Log("clicou");
        }
    }

    void impulsionar()
    {
        this.fisica.AddForce(Vector2.up * impulse, ForceMode2D.Impulse);
    }
}
