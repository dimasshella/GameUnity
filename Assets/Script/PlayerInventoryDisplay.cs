using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] lovePlaceholders;
    public Sprite iconLoveFull;
    public Sprite iconLoveEmpty;
    public void OnChangeLoveTotal(int loveTotal)
    {
        for (int i = 0; i < lovePlaceholders.Length; ++i)
        {
            if (i < loveTotal)
                lovePlaceholders[i].sprite = iconLoveEmpty;
            else
                lovePlaceholders[i].sprite = iconLoveFull;
        }
    }
}
