using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Threading;
//using UnityEngine.Events;

public class asteroid_prefab_scr : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public float rot_vel;
    GameObject spark;
    public Animator animator;
    
    

    // Update is called once per frame

    void Start()
    {
        
    }



    void Update()
    {             
        transform.Rotate(new Vector3(0, 0, rot_vel * Time.deltaTime));
        

    }


    public void OnPointerEnter(PointerEventData eventData)
    {
            
        animator.SetBool("active", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        animator.SetBool("active", false);
    }

    


    public void OnPointerClick(PointerEventData eventData)
    {
        
        spark = GameObject.Find("particle_system1");
        GameObject spawn = (GameObject)Instantiate(spark, transform.position, transform.rotation);
        spawn.GetComponent<ParticleSystem>().Play();
        spawn.GetComponent<AudioSource>().Play();

        Destroy(gameObject);
        


        
        Debug.Log("Clicked on: " + gameObject.name);

    }






}
