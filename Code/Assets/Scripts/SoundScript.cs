using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioSource RacketSound;
    public AudioSource WallSound;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PointWalls")
        {
            WallSound.Play();
        }
        else
        {
            RacketSound.Play();
        }

        

        

    }
}
