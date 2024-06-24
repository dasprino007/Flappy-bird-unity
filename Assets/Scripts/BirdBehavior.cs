using System.Collections;
using UnityEngine;

public class BirdBehavior : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField] private float impulse = 3.0f;
    private SpriteRenderer spriteRenderer;
    public Sprite op2Sprite;
    private Sprite originalSprite;

    private void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSprite = spriteRenderer.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            impulsionar();
            Debug.Log("Mouse Down");
            spriteRenderer.sprite = op2Sprite; // Altera o sprite ao pressionar o botão do mouse
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse Up");
            spriteRenderer.sprite = originalSprite; // Retorna ao sprite original ao soltar o botão do mouse
        }
    }

    void impulsionar()
    {
        fisica.AddForce(Vector2.up * impulse, ForceMode2D.Impulse);
    }
}
