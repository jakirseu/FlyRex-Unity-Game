using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerHitSound, playerFlying, addScore;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        playerHitSound = Resources.Load < AudioClip > ("game-over");
        playerFlying = Resources.Load<AudioClip>("fly");
        addScore = Resources.Load<AudioClip>("score");

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {

        switch (clip)
        {
            case "fall":
                audioSource.PlayOneShot(playerHitSound);
                break;

            case "fly":
                audioSource.PlayOneShot(playerFlying);
                break;
            case "score":
                audioSource.PlayOneShot(addScore);
                break;



        }
    }
}
