using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class SigListener : MonoBehaviour
{
    public Sig sig; 
    public UnityEvent sigEvent;
    public void OnSignalRaised(){
        sigEvent.Invoke(); 
    }
    private void OnEnable(){
         sig.RegisterListener(this); 
    }
    private void OnDisable(){
        sig.DeRegisterListener(this); 
    }
}
