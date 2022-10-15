using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLoop : MonoBehaviour
{
    private GameManager gameManagerScript;
    private AudioSource gameAudio;
    public AudioClip levelwin;

    void Start()
    {
        gameAudio = GetComponent<AudioSource>();
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Game Music");
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (gameManagerScript.playAudio)
        {
            gameAudio.PlayOneShot(levelwin, 1.0F);
            gameManagerScript.playAudio = false;
        }
    }
}
