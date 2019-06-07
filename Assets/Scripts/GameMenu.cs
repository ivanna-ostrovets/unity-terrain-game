using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 
    
    public void EndGame()  
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Escape)) return;
        
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
