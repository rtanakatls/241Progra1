using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private Button testButton;

    private void Awake()
    {
        int a = 10;
        testButton.onClick.AddListener(() =>
        {
            Debug.Log($"Clicked {a}");
            a++;
        });
    }
    

    void Start()
    {
        PlayerLife.Instance.OnLifeChanged += UpdateLife;
    }

    void UpdateLife(int life)
    {
        lifeText.text = $"Life: {life}";
    }

    private void OnDestroy()
    {
        PlayerLife.Instance.OnLifeChanged -= UpdateLife;
    }
}
