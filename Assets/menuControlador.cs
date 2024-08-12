using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MenuEvents : MonoBehaviour
{
    private UIDocument _document;
    private Button _button;
    private Button _button2;
    private Button _button3;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _button = _document.rootVisualElement.Q<Button>("btnJogar");
        _button2 = _document.rootVisualElement.Q<Button>("btnCreditos");
        _button3 = _document.rootVisualElement.Q<Button>("btnMenu");
        _button.RegisterCallback<ClickEvent>(OnPlayGameClick);
        _button2.RegisterCallback<ClickEvent>(OnPlayGameClick2);
        _button3.RegisterCallback<ClickEvent>(OnPlayGameClick3);

    }
    private void OnDisable()
    {
        _button.UnregisterCallback<ClickEvent>(OnPlayGameClick);
    }

    private void OnPlayGameClick(ClickEvent evt)
    {
        SceneManager.LoadScene("flappyScene");
    }
    private void OnPlayGameClick2(ClickEvent evt)
    {
        SceneManager.LoadScene("Creditos");
    }
    private void OnPlayGameClick3(ClickEvent evt)
    {
        SceneManager.LoadScene("Menu");
    }
}
