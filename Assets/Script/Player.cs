
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text pattyText;
    private int totalPatty = 0;
    void Start()
    {
        UpdatePattyText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Patty"))
        {
            totalPatty++;
            UpdatePattyText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdatePattyText()
    {
        string pattyMessage = "patty = " + totalPatty;
        pattyText.text = pattyMessage;
    }

}
