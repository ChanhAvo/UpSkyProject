using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HeartManager : MonoBehaviour
{
    public Image[] hearts; 
    public Sprite fullHeart;
    public Sprite halfFullHeart; 
    public Sprite emptyHeart; 
    public FloatValue heartContainers; 
    void Start()
    {
        InitHearts(); 
    }
    public void InitHearts(){
        for(int i = 0; i < heartContainers.initValue; i++){
            hearts[i].gameObject.SetActive(true); 
            hearts[i].sprite = fullHeart; 
        }
    }  
}
