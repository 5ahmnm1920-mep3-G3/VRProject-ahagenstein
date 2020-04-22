using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;



public class EggCollector : MonoBehaviour
{
    private const string EGG_TAG = "egg";
    private int eggCount;
    public Animation globeAnimation;
    public Animation rabbitAnimation;
    public AudioSource happyNoise;
    public GameObject winningText;
    public AudioSource celebration;
    public AudioSource eggInputSound;
    public int minEggs = 5;

    private void OnTriggerEnter(Collider coll)
    {
        //check ob egg, wenn nicht dann geh einfach
        if (!coll.CompareTag(EGG_TAG)) return;
        //füge ein egg hinzu
        eggCount++; print(eggCount);
        //Spiele Globus animation
        globeAnimation.Play();
        //Sound wird abgespielt wenn ein Ei in den Pot geworfen wird
        eggInputSound.Play();
        //cheaten nicht ermöglichen, Eier nicht mehr aus Pot nehmen können 
        coll.GetComponent<Interactable>().enabled = false;
        //wenn 5 Eier im Pot dann epic party
        if (eggCount >= minEggs)
        {
            rabbitAnimation.Play();
            happyNoise.Play();
            celebration.Play();
            winningText.SetActive(true);


        }

    }




}
