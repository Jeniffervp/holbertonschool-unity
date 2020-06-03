using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    public float speed = 500f;
    public Rigidbody rigb;
    private int score = 0;
    public int health = 5;
    public Text scoreText;
    public Text healthText;
    public Text winLoseText;
    public Image winLoseBG;
    public bool plane = true;
    public GameObject joyStick;

    public void Update()
    {
        if (health == 0)
        {
            winLoseText.color = Color.white;
            winLoseText.text = "Game Over!";
            winLoseBG.color = new Color32(118, 18, 6, 220);
            winLoseBG.gameObject.SetActive(true);
            StartCoroutine(LoadScene(3));
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void FixedUpdate()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            if (Input.touchCount > 0)
            {
                plane = false;
                joyStick.gameObject.SetActive(true);
                float axisX = CrossPlatformInputManager.GetAxis("Horizontal") * (speed * Time.deltaTime);
                float axisZ = CrossPlatformInputManager.GetAxis("Vertical") * (speed * Time.deltaTime);
                rigb.AddForce(axisX, 0, axisZ);
            }
            else
            {
                Vector3 accelerometer = Input.acceleration;
                if (plane)
                {
                    accelerometer = Quaternion.Euler(90, 0, 0) * accelerometer;
                    rigb.AddForce(accelerometer);
                }
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
                rigb.AddForce(0, 0, speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.RightArrow))
                rigb.AddForce(speed * Time.deltaTime, 0, 0);
            if (Input.GetKey(KeyCode.LeftArrow))
                rigb.AddForce((-1 * speed) * Time.deltaTime, 0, 0);
            if (Input.GetKey(KeyCode.DownArrow))
                rigb.AddForce(0, 0, (-1 * speed) * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score += 1;
            SetScoreText();
            Destroy(other.gameObject);
        }

        if (other.tag == "Trap")
        {
            health -= 1;
            SetHealthText();
        }

        if (other.tag == "Goal")
        {
            winLoseText.color = Color.white;
            winLoseText.text = "You Win!";
            winLoseBG.color = new Color32(50, 122, 6, 220);
            winLoseBG.gameObject.SetActive(true);
            StartCoroutine(LoadScene(3));
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(0);
    }
}
