using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Animatiion : collision
{
    // Start is called before the first frame update
    public Slider _slider;
    public GameObject smoke;
    public GameObject fire;
    public float smokevalue = 200f;
    public float firevalue = 200f;
    //GameOver
    public GameObject gameoverUI;
    public static bool GameOvercheck = false;
    //Grounded
    public Transform GroundCheck;
    public float GroundDistance = 0.4f; //Reduis of the sphere
    public LayerMask GroundMask;
    bool isGrounded;
    public AudioSource carturns;
    // Update is called once per frame
    void Update()
    {
        if(_slider.value<=smokevalue)
        {
            smoke.SetActive(true);
        }
        if(_slider.value<=firevalue)
        {
            fire.SetActive(true);   
        }
        if(_slider.value==0)
        {
            GameOver();
        }

        isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);  //returns true when the player collids with anything
                                                                                             //in our groundMask else return false
        if (isGrounded)
        {
            GameOver();
        }
        if(Input.GetKey("d"))
        {
            carturns.PlayOneShot(carturns.clip);
        }
        if (Input.GetKey("a"))
        {
            carturns.PlayOneShot(carturns.clip);
        }
    }
    public void GameOver()
    {
        FindObjectOfType<PlayerMovement>().speed = 0;
        if(GameOvercheck == false)
        {
            gameoverUI.SetActive(true);
        }
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
