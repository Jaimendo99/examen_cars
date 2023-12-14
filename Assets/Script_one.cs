using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_one : MonoBehaviour
{
    // Start is called before the first frame update
    public Text lapCounterText;
    private int lapCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is tagged as a "Car" or add specific car tags
        if (other.CompareTag("Car"))
        {
            lapCount++;
            UpdateLapCounterText();
        }
    }

    private void UpdateLapCounterText()
    {
        if (lapCounterText != null)
        {
            lapCounterText.text = "Laps: " + lapCount.ToString();
        }
    }

}
