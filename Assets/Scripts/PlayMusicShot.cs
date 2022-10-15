using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicShot : MonoBehaviour
{
    private GameManager gameManagerScript;
    private AudioSource gameAudio;
    public AudioClip levelwin;

    // Start is called before the first frame update
    void Start()
    {
        gameAudio = GetComponent<AudioSource>();
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.playAudio)
        {
            gameAudio.PlayOneShot(levelwin);
            gameManagerScript.playAudio = false;
        }
    }
}
