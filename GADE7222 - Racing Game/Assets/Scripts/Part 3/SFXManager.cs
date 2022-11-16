using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public Hashtable audioHash;
    public AudioClip sCrash;
    public AudioClip sAcc;
    public AudioClip sCheckpoint;
    public AudioClip sTimer;
    public AudioClip sFans;
    public AudioSource source;


    void Awake()
    {
        audioHash = new Hashtable();
        audioHash.Add("crash", sCrash);
        audioHash.Add("checkpoint", sCheckpoint);
        audioHash.Add("timer", sTimer);
        audioHash.Add("rev", sAcc);
        audioHash.Add("fans", sFans);
    }

    public void PlaySound(string name)
    {
        foreach (DictionaryEntry idHash in audioHash)
        {
            if (idHash.Key.ToString() == name)
            {
                source.PlayOneShot((AudioClip)idHash.Value);
            }

        }
    }
}
