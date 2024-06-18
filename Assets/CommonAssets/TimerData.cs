using UnityEngine;
using TMPro;  // Include the TextMeshPro namespace
using UnityEngine.SceneManagement;  // Include the SceneManagement namespace

public class TimerData : MonoBehaviour
{
    public int countUp = 0;
    private static bool created = false;  // Flag to check if the GameObject has been created

    // Start is called before the first frame update
    void Start()
    {
        if (!created)
        {
            // This GameObject will survive when a new scene is loaded
            DontDestroyOnLoad(this.gameObject);
            created = true;

            // Call the IncreaseCountUp function every second
            InvokeRepeating("IncreaseCountUp", 1.0f, 1.0f);
        }
    }

    void IncreaseCountUp()
    {
        countUp++;

        if (countUp >= 60 * 10)
        {
            SceneManager.LoadScene("End");
        }
        if(SceneManager.GetActiveScene().name == "End")
        {
            CancelInvoke("IncreaseCountUp");
        }
    }
}