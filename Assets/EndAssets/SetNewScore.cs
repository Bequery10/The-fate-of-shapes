// using System.IO;
// using UnityEngine;
// using TMPro; 
// Assets/EndAssets/ScoreBoard
// public class SetNewScore : MonoBehaviour
// {
//     // Path of the file
//     private string path;
//     private string time;

//     private TextMeshProUGUI textMesh;

//     void Start()
//     {
//          textMesh = GetComponent<TextMeshProUGUI>();  // Get the TextMeshProUGUI component
        
//         string content1= textMesh.text ;
//         string[] lines1 = content1.Split('\n');  // Split the string into lines
//         int currentTime=int.Parse(lines1[1]);

//         // Set the path of the file
//         path = "Assets/EndAssets/ScoreBoard.txt";

//         string content = ReadFromFile();
//         string[] lines = content.Split('\n');  // Split the string into lines
// if (lines.Length > 1)  // Check if there is a second line
// {
//     int index = lines[1].IndexOf(' ');  // Find the index of the first space in the second line
//     if (index != -1)  // Check if a space was found
//     {
//         string time = lines[1].Substring(index + 1);  // Get the time from the second line
//         int highestTime = int.Parse(time);  // Parse the time to an integer
       
//         if(currentTime<highestTime){
//             WriteToFile("Name: "+name+"\Time: "+currentTime);
//         }
       
//     }
//     else
//     {
//         WriteToFile("Name: "+name+"\Time: "+currentTime);
//     }
// }
// else
// {
//      WriteToFile("Name: "+name+"\Time: "+currentTime);
// }

       
//     }

//     void WriteToFile(string content)
//     {
//         // Create a new file and write the content to it
//         File.WriteAllText(path, content);
//     }

//     string ReadFromFile()
//     {
//         // Check if the file exists
//         if (File.Exists(path))
//         {
//             // Read the content of the file
//             string content = File.ReadAllText(path);
//             return content;
//         }
//         else
//         {
//             Debug.LogError("The file does not exist.");
//             return null;
//         }
//     }
// }

