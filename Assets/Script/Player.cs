using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    public Text pattyText;
    private int totalPatty = 0;
    private int totalLove = 0;
    void Start()
    {
        UpdatePattyText();
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Patty"))
        {
            totalPatty++;
            UpdatePattyText();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("Plankton"))
        {
            totalLove++;
            playerInventoryDisplay.OnChangeLoveTotal(totalLove);
            Destroy(hit.gameObject);
        }
    }
    private void UpdatePattyText()
    {
        string pattyMessage = "patty = " + totalPatty;
        pattyText.text = pattyMessage;
    }

}
