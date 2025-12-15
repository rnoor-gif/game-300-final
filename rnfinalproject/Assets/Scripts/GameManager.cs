using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI countText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = 0;
        UpdateCount(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCount(int countAdd)
    {
        count += countAdd;
        countText.text = "Marbles: " + count;
    }
}
