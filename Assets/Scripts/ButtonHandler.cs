using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Button myButton; // Ссылка на кнопку

    void Start()
    {
        myButton.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        Debug.Log("Button Clicked!");
        // Добавьте свой код для обработки нажатия кнопки
    }
}