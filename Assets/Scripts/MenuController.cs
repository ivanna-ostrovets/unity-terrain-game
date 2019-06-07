using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()  
    {
        SceneManager.LoadScene(1);
    }  
    
    public void EndGame()  
    {
        Application.Quit();
    }
    
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Escape)) return;
        
        Application.Quit();
    }  
}