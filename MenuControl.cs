using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public bool menuOpen = false;
    public GameObject menu;

    public float soundVolume;
    public float musicVolume;
    public Slider sound;
    public Slider music;

    public AudioSource musicSource;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sound.maxValue = 1.0f;
        sound.minValue = 0.0f;

        music.maxValue = 1.0f;
        music.minValue = 0.0f;

        musicSource = (AudioSource)GetComponent("AudioSource");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (menuOpen)
            {
                menuOpen = false;
                
            }
            else
            {
                menuOpen = true;
            }
            menu.SetActive(menuOpen);
        }

        if (menuOpen)
        {
            AudioListener.volume = sound.value;
            musicSource.volume = music.value;
        }
    }
}
