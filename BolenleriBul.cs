using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdevScript : MonoBehaviour
{
    void bolenleriBul(int ilksayi, int ikincisayi)
    {
        ArrayList sayiListesi = new ArrayList();
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            sayiListesi.Add(i);
        }
        string listeString = "Tüm Liste:";
        foreach (int eleman in sayiListesi)
        {
            listeString += " - " + eleman;
        }
        print(listeString);
        listeString = "İkiye Bölünenler:";
        foreach (int eleman in sayiListesi)
        {
            if (eleman % 2 == 0) listeString += " - " + eleman;
        }
        print(listeString);
        listeString = "Üçe Bölünenler:";
        foreach (int eleman in sayiListesi)
        {
            if (eleman % 3 == 0) listeString += " - " + eleman;
        }
        print(listeString);
        listeString = "Dörde Bölünenler:";
        foreach (int eleman in sayiListesi)
        {
            if (eleman % 4 == 0) listeString += " - " + eleman;
        }
        print(listeString);
        listeString = "Beşe Bölünenler:";
        foreach (int eleman in sayiListesi)
        {
            if (eleman % 5 == 0) listeString += " - " + eleman;
        }
        print(listeString);





    }
    // Start is called before the first frame update
    void Start()
    {
        bolenleriBul(20, 44);

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
