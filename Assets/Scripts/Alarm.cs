using UnityEngine;

[RequireComponent(typeof(Light))]
public class Alarm : MonoBehaviour
{
    //alarm sound
    public AudioSource alarmSound;
    //the ball game object
    public GameObject ball;
    //the balls position
    public Vector3 ballPos;

    // Use this for initialization
    void Start()
    {
        //set to the ball objects initial position
        ballPos = ball.transform.localPosition;
    }

    public void OnTriggerEnter(Collider collider)
    {
        //if ball has reached goal play sound
        if (collider.gameObject == ball)
        {
            //play the sound
            alarmSound.Play();

        }
    }

    public void OnTriggerExit(Collider collider)
    {
        //if ball has reached goal play sound
        if (collider.gameObject == ball)
        {
            //stop the sound
            alarmSound.Stop();
            //reset the ball
            ball.transform.localPosition = ballPos;
        }
    }
}
