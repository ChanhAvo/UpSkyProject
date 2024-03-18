using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Sig : ScriptableObject 
{
    public List<SigListener> listeners = new List<SigListener>(); 
    public void Raise(){
       for(int i = listeners.Count - 1; i >= 0; i--) 
       {
          listeners[i].OnSigRaised(); 
       } 
    }
    public void RegisterListener(SigListener listener){
        listeners.Add(listener); 
    }
    public void DeRegisterListener(SigListener listener){
        listeners.Remove(listener); 
    }
}
