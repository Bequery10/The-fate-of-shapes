using UnityEngine;
using TMPro;  // Include the TextMeshPro namespace
using UnityEngine.SceneManagement; 
public class CountDown : MonoBehaviour
{
    private TextMeshProUGUI textMesh;  // Reference to the TextMeshProUGUI component
    public int countdown = 60;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();  // Get the TextMeshProUGUI component
        
        textMesh.text = countdown.ToString();  // Set the text

        // Call the DecreaseCountdown function every second
        InvokeRepeating("DecreaseCountdown", 1.0f, 1.0f);
    }


    void DecreaseCountdown()
    {
        if (countdown > 0)
        {
            countdown--;
            textMesh.text = countdown.ToString();
        }
        else
        {
            CancelInvoke("DecreaseCountdown");
             SceneManager.LoadScene("End"); 
        }
    }
}