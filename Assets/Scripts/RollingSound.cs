using UnityEngine;
using System.Collections;

public class RollingSound : MonoBehaviour
{

    //the audio to play when rolling
    public AudioSource rollAudioSource;
    //the audio to play on wall collision
    public AudioSource wallAudioSource;
    //the balls rigid body
    Rigidbody _rigidbody;
    //collision counter
    int _collisionCount = 0;

    // Use this for initialization
    void Start()
    {
        //sets the rigidbody
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if collision is greater than zero
        if (_collisionCount > 0)
        {
            //if audio is not playing
            if (rollAudioSource.isPlaying == false)
            {
                //play audio
                rollAudioSource.Play();
            }

            float volume = Mathf.Clamp(_rigidbody.velocity.magnitude, 0.0f, 1.0f);
            // set volume.

            rollAudioSource.volume = volume;
        }
        else
        {
            //if the audio is playing
            if (rollAudioSource.isPlaying)
            {
                //stop it
                rollAudioSource.Stop();
            }
        }
    }

    public void OnCollisionEnter(Collision coll)
    {
        //if the collision was with the wall
        if (coll.gameObject.name.Contains("Wall"))
        {
            //play the wall audio sound
            wallAudioSource.Play();
        }
        //increase counter
        _collisionCount++;
    }

    public void OnCollisionExit(Collision coll)
    {
        //if the collision was with the wall
        if (coll.gameObject.name.Contains("Wall"))
        {
            //stop the audio
            wallAudioSource.Stop();
        }
        //decrease counter
        _collisionCount--;
    }

}
