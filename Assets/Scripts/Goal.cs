using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    //the sound to activate
    public AudioSource goalSound;
    //the ball
    public GameObject ball;

    public void OnCollisionEnter(Collision collision)
    {
        //if ball has reached goal play sound
        if (collision.collider.gameObject == ball)
        {
            //play the audio
            goalSound.Play();
        }
        //start coroutine that waits for audio to finish playing
        StartCoroutine(WaitUntilSoundStops());

        
    }

    //wait for audio to finish playing, then load main menu
    IEnumerator WaitUntilSoundStops()
    {
        //wait for audio to finish
        yield return new WaitForSeconds(goalSound.clip.length);
        //load main menu scene
        SceneManager.LoadScene("MainMenu");
    }
}
