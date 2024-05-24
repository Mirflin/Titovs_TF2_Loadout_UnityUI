using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelTriggerScript : MonoBehaviour
{

    private GameObject image;
    private Sprite name;
    public GameObject Jefe1;
    public GameObject Gibus1;
    public GameObject WizzardHat1;
    public GameObject PrefabSpot;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered!");
        name = other.GetComponent<Image>().sprite;
        Debug.Log(name);
        if (name.name == "DragImage")
        {
            Gibus1.SetActive(false);
            WizzardHat1.SetActive(false);
            Jefe1.SetActive(true);
        }
        else if (name.name == "hallowenHatDrag")
        {
            Gibus1.SetActive(false);
            WizzardHat1.SetActive(true);
            Jefe1.SetActive(false);
        }
        else
        {
            Gibus1.SetActive(true);
            WizzardHat1.SetActive(false);
            Jefe1.SetActive(false);
        }
        PrefabSpot.SetActive(false);
    }
}
