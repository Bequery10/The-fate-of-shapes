using UnityEngine;
using TMPro;  // Include the TextMeshPro namespace
using UnityEngine.SceneManagement;  // Include the SceneManagement namespace

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI textMesh;  // Reference to the TextMeshProUGUI component
    private int countUp = 0;
    private static bool created = false;  // Flag to check if the GameObject has been created

    // Start is called before the first frame update
    void Start()
    {
        if (!created)
        {
            transform.SetParent(null, false);
            // This GameObject will survive when a new scene is loaded
            DontDestroyOnLoad(this.gameObject);
            created = true;

            textMesh = GetComponent<TextMeshProUGUI>();  // Get the TextMeshProUGUI component
            textMesh.text = countUp.ToString();  // Set the text

            // Call the IncreaseCountUp function every second
            InvokeRepeating("IncreaseCountUp", 1.0f, 1.0f);
        }
    }

    void IncreaseCountUp()
    {
        countUp++;
        textMesh.text = "Elapsed Time:\n" + countUp.ToString();

        if (countUp >= 60 * 10)
        {
            SceneManager.LoadScene("End");
        }
    }
}