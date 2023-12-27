using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdevScripti : MonoBehaviour
{
    static void bolenleriBul(int ilkSayi, int ikinciSayi)
    {
        List<int> tumListe = new List<int>();
        String listString = "";

        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            tumListe.Add(i);
        }

        foreach (int sayi in tumListe)
        {
            listString += sayi + " - ";
        }
        print("Tüm Liste: " + listString);

        listString = "";

        for (int i = 0; i < tumListe.Count; i++)
        {
            if (tumListe[i] % 2 == 0)
            {
                listString += tumListe[i] + " - ";
            }
        }
        print("İkiye bölünenler " + listString);

        listString = "";
        for (int i = 0; i < tumListe.Count; i++)
        {
            
            if (tumListe[i] % 3 == 0)
            {
                listString += tumListe[i] + " - ";
                
            }
            
        }
        print("Üçe bölünenler " + listString);
        listString = "";
        for (int i = 0; i < tumListe.Count; i++)
        {

            if (tumListe[i] % 5 == 0)
            {
                listString += tumListe[i] + " - ";

            }

        }
        print("Beşe bölünenler " + listString);
    }

// Start is called before the first frame update
void Start()
    {
        bolenleriBul(12,16);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
