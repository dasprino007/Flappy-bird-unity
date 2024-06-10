using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UiControle : MonoBehaviour
{
    private Label textPontos;
    private int pontos;
    public void AdicionarPontos()
    {
        this.textPontos.text = this.pontos.ToString();
        this.pontos++;
    }
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        this.textPontos = root.Q<Label>("pontos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
