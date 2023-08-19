using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Button myButton; // ������ �� ������

    void Start()
    {
        myButton.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        Debug.Log("Button Clicked!");
        // �������� ���� ��� ��� ��������� ������� ������
    }
}