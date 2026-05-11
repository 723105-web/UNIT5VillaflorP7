using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficullty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficullty()
    {
        Debug.Log(button.gameObject.name + "was clicked");
    }
}
