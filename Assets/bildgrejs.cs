using UnityEngine;
using TMPro;

public class bildgrejs : MonoBehaviour
{
    public TMP_Text scoreTextBox;
    public int Score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextBox.text = "Score is: " + Score;
    }
}
