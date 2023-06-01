using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AffichageFin : MonoBehaviour
{

    [SerializeField] private TMP_Text _txtTempsTotal;

    [SerializeField] private TMP_Text _txtPointageTotal;

    private GestionTemps _gestionTemps;
    private ItemCollector pointage;
    // Start is called before the first frame update
    void Start()
    {
        _txtTempsTotal.text = "Temps Total : " + _gestionTemps.GetTempsFinal().ToString("f2") + " sec.";
        _txtPointageTotal.text = "Pointage Final : " + pointage.GetOranges().ToString(); 
    }

    
}
