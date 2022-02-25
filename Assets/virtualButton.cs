using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualButton : MonoBehaviour
{
    public GameObject cube;
    public VirtualButtonBehaviour VB;
    // Start is called before the first frame update
    void Start()
    {
        VB.RegisterOnButtonPressed(OnButtonPressed);
        VB.RegisterOnButtonReleased(OnButtonReleased);
        cube.SetActive(false);
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour VB){
        cube.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour VB){
        cube.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
