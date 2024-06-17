using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdBehavior : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    private float impulse = 3.0f;
    private SpriteRenderer op2;
    public Sprite op2Sprite;

    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
        this.op2 = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.impulsionar();
            Debug.Log("clicou");
            this.op2.sprite = op2Sprite;
        }
    }

    void impulsionar()
    {
        this.fisica.AddForce(Vector2.up * impulse, ForceMode2D.Impulse);
    }
}
