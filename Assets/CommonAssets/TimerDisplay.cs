using UnityEngine;
using TMPro;  // Include the TextMeshPro namespace
using UnityEngine.SceneManagement;
public class TimerDisplay : MonoBehaviour
{
    private TextMeshProUGUI textMesh;  // Reference to the TextMeshProUGUI component
    private TimerData timerData;  // Reference to the TimerData component

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();  // Get the TextMeshProUGUI component
        timerData = GameObject.FindObjectOfType<TimerData>();  // Get the TimerData component
    
    }

    // Update is called once per frame
    void Update()
    {
        if (timerData != null && SceneManager.GetActiveScene().name != "End")
        {
            textMesh.color=Color.black;
            textMesh.text = "Timer:\n" + timerData.countUp.ToString();
        }

         else if(SceneManager.GetActiveScene().name == "End"){
            textMesh.text="";
            
            // Get the TextMeshProUGUI component
            TextMeshProUGUI textMesh1 = GameObject.Find("Canvas").GetComponentInChildren<TextMeshProUGUI>();
            //Debug.Log(textMesh1);
            // Set the text of the TextMeshProUGUI component
            textMesh1.text = "Spent Time:\n    " + timerData.countUp.ToString();
            // Change the text color of textMesh1
            textMesh1.color = Color.red;

            // Change the placement of textMesh1
            textMesh1.rectTransform.anchoredPosition = new Vector2(75, 14);
          }

    }
}