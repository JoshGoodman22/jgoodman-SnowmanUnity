using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour {
public AudioSource Bang;

public AudioSource Beep;

public AudioSource Ding;

public AudioSource Boom;


    public void PlayBang()
{
    Bang.Play ();  
}
    public void PlayBeep()
{
    Beep.Play ();  
}
    public void PlayDing()
{
    Ding.Play ();  
}
    public void PlaBoom()
{
    Boom.Play ();  
}



}