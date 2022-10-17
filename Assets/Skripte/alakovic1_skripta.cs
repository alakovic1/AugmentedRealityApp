using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alakovic1_skripta : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;
    public GameObject video;
    public GameObject stopSfera;
    public GameObject audioTruba;
    public GameObject trubackiTekst;
    public GameObject tekstZaPrekid;
    public GameObject informacije;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "alakovic1_POI2lampa")
            {
                video.SetActive(true);
                stopSfera.SetActive(true);
                tekstZaPrekid.SetActive(true);
            }
            if (hit.collider.gameObject.name == "alakovic1_sferaSTOP")
            {
                video.SetActive(false);
                stopSfera.SetActive(false);
                audioTruba.SetActive(false);
                trubackiTekst.SetActive(false);
                tekstZaPrekid.SetActive(false);
                informacije.SetActive(false);
            }
            if (hit.collider.gameObject.name == "alakovic1_POI3truba")
            {
                audioTruba.SetActive(true);
                stopSfera.SetActive(true);
                trubackiTekst.SetActive(true);
                tekstZaPrekid.SetActive(true);
            }
            if (hit.collider.gameObject.name == "alakovic1_POI1krst")
            {
                informacije.SetActive(true);
                stopSfera.SetActive(true);
                tekstZaPrekid.SetActive(true);
            }
        }
    }
}
