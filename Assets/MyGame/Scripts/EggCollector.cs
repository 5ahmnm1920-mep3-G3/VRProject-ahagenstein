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

    private void OnTriggerEnter(Collider coll)
    {
        //check ob egg, wenn nicht dann geh einfach
        if (!coll.CompareTag(EGG_TAG)) return;
        //füge ein egg hinzu
        eggCount++; print(eggCount);
        //Spiele Globus animation
        globeAnimation.Play();
        //cheaten nicht ermöglichen, Eier nicht mehr aus Pot nehmen können 
        coll.GetComponent<Interactable>().enabled = false;
        //wenn 5 Eier im Pot dann epic party
        if (eggCount >= 5)
        {
            rabbitAnimation.Play();
            happyNoise.Play();
        }

    }




}
