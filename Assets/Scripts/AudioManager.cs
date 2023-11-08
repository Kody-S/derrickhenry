using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Santos' Cool Audio Manager yippee yahoo
// You only need one AudioManager in your whole project
// as the AudioManager will move with you through scenes.

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Background Music")]
    public AudioClip bgmScene1; // scene 0
    public AudioClip bgmScene2; // scene 1
    public AudioClip bgmScene3; // scene 2
    public AudioClip bgmScene4; // scene 3

    [Header("Sound Effects")]

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Start playing the initial background music
        PlayBackgroundMusic(bgmScene1);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Handle background music for different scenes
        if (scene.name == "Opening Cover")
        {
            PlayBackgroundMusic(bgmScene1);
        }
        else if (scene.name == "Game Scene 1(W.C)")
        {
            PlayBackgroundMusic(bgmScene2);
        }
        else if (scene.name == "Entrance")
        {
            PlayBackgroundMusic(bgmScene2);
        }
        else if (scene.name == "Entrance")
        {
            PlayBackgroundMusic(bgmScene2);
        }
    }

    // Play background music and handle overlapping
    void PlayBackgroundMusic(AudioClip clip)
    {
        if (musicSource.clip != clip)
        {
            musicSource.clip = clip;
            musicSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Handle other audio-related updates if needed
    }
}
