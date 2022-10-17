using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alakovic1_infoSkripta : MonoBehaviour {

    public Text infoTekst;
    private int i = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onInfo() {
        if(++i % 2 != 0) infoTekst.text = "";
        else infoTekst.text = "Dobro došli!" + Environment.NewLine +
                "Ova aplikacija omogućava predstavljanje" + Environment.NewLine + 
                "3D modela glavnog obilježja Krakowa u Poljskoj," + Environment.NewLine + 
                "St. Mary's Basilicu, sagrađenu u 14. stoljeću." + Environment.NewLine + 
                "Imate mogućnost odabira sporednih objekata," + Environment.NewLine + 
                "te uz pomoć njih da saznate nešto o ovoj građevini." + Environment.NewLine + 
                "Lampa pokreće video, krst tekst o cijeni ulaska i" + Environment.NewLine + 
                "truba (zakačena na toranj) poznati zvuk ove crkve." + Environment.NewLine + 
                "Prekidate uz pomoć crvenog kruga, a izlazite iz" + Environment.NewLine +
                "aplikacije na X. Uživajte!!" + Environment.NewLine + 
                "Amila Laković" + Environment.NewLine + 
                "Sarajevo, 2020.";
    }
}
