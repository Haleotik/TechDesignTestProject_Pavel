using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using Unity.VisualScripting;
//using UnityEngine.Events;

public class bird_level_2 : MonoBehaviour, IPointerClickHandler
{
    public float gravity_vel;
    GameObject spark;
    public Animator animator;
    public GameObject wingSound;

    // Update is called once per frame

    void Start()
    {
        spark = GameObject.Find("particle_system3");
    }

    void Update()
    {             
        transform.Translate(new Vector3(0, gravity_vel * Time.deltaTime, 0));
        
        if (gravity_vel > -10)
        {
            gravity_vel -= 0.1f;
            animator.SetBool("active", true);
        }
        else
        {
            animator.SetBool("active", false);
            wingSound.GetComponent<AudioSource>().volume -= 0.05f;

        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject spawn = (GameObject)Instantiate(spark, transform.position, transform.rotation);
        spawn.GetComponent<ParticleSystem>().Play();
        //on_sprite = true;
        gravity_vel = 20;
        wingSound.GetComponent<AudioSource>().Play();
        wingSound.GetComponent<AudioSource>().volume = 1;


        Debug.Log("Clicked on: " + gameObject.name);
    }
}
