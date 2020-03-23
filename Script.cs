using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //typ zmiennej nazwa;
        //deklaracja
        int a;
        // inicjalizacja przypisanie konkretnej wartosci
        a = 10;
        //2 w 1
        int b = 20;

        {//skakanie
        Debug.Log(b);
        }

        {//chodzenie
         int c = 20;
         }
        
        //Debug.Log(c);

        float fa = 1.5f;
        fa = 4;
        bool logiczna = true; //false
        string str = "jakiś napis";

        Debug.Log(" fa: "+ fa + " logiczna: " + logiczna + " str: " + str);

        //operacje na zmiennych + - * /
    Debug.Log(a/b);
    Debug.Log(a/fa);
    Debug.Log(Mathf.Sqrt(2));

    //operacje logiczne
    Debug.Log(a == b); //równe
    Debug.Log(a != b); // różne
    Debug.Log(a >= b);
    Debug.Log(a < b);
    Debug.Log(a <= b);


    //if (warunek_logiczny){

    //}
    if(a == b){
    Debug.Log("Tak, jest taka sama!");
    } else if (a>b){
    Debug.Log("Tak, jest różna!")
    } else {
        Debug.Log("żadna z powyższych");
    }
    Koniunkcja (a,b);
    Alternatywa ();

   


 public void Koniunkcja(int a, int b) {
     //koniunkcja
    Debug.Log ((a != b) && (a > 0));

    if( a != b){
        if (a > 0){
            //kod
        }
    }

    if ((a != b) && (a > 0)){
        //kod
    }


 }

 public void Alternatywa () {
     //brzydka wersja
    int hp = 2, time = 1;
    bool amulet = true;
    if(hp=0){
    if (amulet {//sprawdzamy czy amulet == false}
    }else{
}

//ładna wersja
if ((hp <=0) ||() time <= 0)){
    if (amulet){
        //sprawdzamy czy amulet == false
    }else {
    }
 }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
