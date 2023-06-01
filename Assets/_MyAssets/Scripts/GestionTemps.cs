using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionTemps : MonoBehaviour
{

    

    // Start is called before the first frame update

    public TextMeshProUGUI timerText;
    public float currentTime=0;
    public bool countDown;
    private float _tempsFinal = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        timerText.text = "Temps : " + currentTime.ToString("f2");
        
    }
    public void SetTempsFinal(float p_tempFinal)
    {
        _tempsFinal = p_tempFinal - currentTime;
    }

    public float GetTempsFinal()
    {
        return _tempsFinal;
    }




}
