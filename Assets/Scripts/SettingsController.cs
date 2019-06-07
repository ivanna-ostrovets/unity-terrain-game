using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public Slider slider;
    public GameObject mainMenu;
        
    public void OnVolumeChanged(float volume)
    {
        AudioListener.volume = volume;
    }
    
    void Start()
    {
        slider.value = AudioListener.volume;
    }
    
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Escape)) return;

        gameObject.SetActive(false);
        mainMenu.SetActive(true);
    }
}
 