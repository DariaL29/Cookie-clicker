using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float cooldown;

    public Text CookieText;

    public float counter;

    private int cookie;

    public List<string> Names = new List<string>();

    public List<int> Numbers = new List<int>();

    public List<int> Costs = new List<int>();

    public List<int> Cooldowns = new List<int>();

    public List<int> Rates = new List<int>();

    private List<float> Counters = new List<float> {0, 0, 0};


    public Text CookerButtonText;
    public Text OvenButtonText;
    public Text BakeryButtonText;

    
    //private float timeStampBakery;

    //bool bakery;


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        cookie = 0;
        CookieText.text = "Pigs: 0";
        

    }




    public void ManualIncrement()
    {
       cookie = Increment(1);
    }


    // Update is called once per frame
    void Update()
    {
       //ChecksBakeryCooldown();

       //adds cookies automatically
       counter += Time.deltaTime;
       Counters[0] += Time.deltaTime;
       Counters[1] += Time.deltaTime;
       Counters[2] += Time.deltaTime;
       

       if( counter >= cooldown)
       {
       cookie = Increment(1);
       counter -= cooldown;
       }

       if(Counters[0] >= Cooldowns[0] && Numbers[0]>0)
        {
          cookie = Increment(Rates[0]);
          Counters[0] -=Cooldowns[0];

        }

       if(Counters[1] >= Cooldowns[1] && Numbers[1]>0)
        {
          cookie = Increment(Rates[1]);
          Counters[1] -=Cooldowns[1];

        }

        if(Counters[2] >= Cooldowns[2] && Numbers[2]>0)
        {
          cookie = Increment(Rates[2]);
          Counters[2] -=Cooldowns[2];

        }

      /* if(Time.time > Cooldowns[1] && Numbers[1]>0)
        {
          cookie = Increment(Rates[1]);
          Counters[1] -=Cooldowns[1];

        }

        if(bakery == true && Numbers[2]>0)
        {
          cookie = Increment(Rates[2]);
          //Counters[1] -=Cooldowns[2];
          

        }*/

//if(Counters[1] >= Cooldowns[1] && Numbers[2]>0)
    } 



    public int Increment (int value)
    {
        int total = cookie + value;
        UpdateCookieDisplay(total);
        return total;

    }
    
public void BuyCooker()
{
    if(cookie >= Costs[0])
    {
        cookie -= Costs[0];
        UpdateCookieDisplay(cookie);

        Numbers[0]++;
        CookerButtonText.text = Names[0]+ ":" + Numbers[0].ToString();
        
    }

}


public void BuyOven()
{
 if(cookie >= Costs[1])
  {
   cookie -= Costs[1];
   UpdateCookieDisplay(cookie);

   Numbers[1]++;
   OvenButtonText.text = Names[1]+ ":" + Numbers[1].ToString();
 
  }

}

public void BuyBakery()

{
 if(cookie >= Costs[2])
  {
   cookie -= Costs[2];
   UpdateCookieDisplay(cookie);

   Numbers[2]++;
  BakeryButtonText.text = Names[2]+ ":" + Numbers[2].ToString();
  //timeStampBakery = Time.time + Cooldowns[2];
 // bakery = true;
  }
}

private void UpdateCookieDisplay(int newNumber)

{
CookieText.text = "Pigs: " + cookie.ToString();
}


/*void ChecksBakeryCooldown()
{
  if (timeStampBakery <= Time.time)
    {
    bakery = true;
    }
 else
    {
    bakery = false;
    }


}*/


}
