using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public float workers = 1f;
    public float materials;
    const float workersSpeed = 0.2f;
    public float workersEndurance = 100f;

    public bool isWork;

    public float budget;

    public bool isSell;

    public bool buyNewWorker;

    public float hirePrice = 10f;

    public float soldiers;
    public float soldiersHirePrice = 15f;
    public bool buyNewSoldier;

    private void Update()
    {
        if (isWork)
        {
            Production();
            isSell = false;
        }

        else
        {
            materials = materials + 0;
            Chill();
            isWork = false;
        }

        if (workersEndurance >= 100f)
        {
            workersEndurance = 100f;
        }

        if (workersEndurance <= 0f)
        {
            workersEndurance = 0f;
            isWork = false; 
        }

        if (isSell)
        {
            Sell();
        }

        if (buyNewWorker)
        {
            BuyNewWorker();
        }

        if (buyNewSoldier)
        {
            BuyNewSoldier();
        }

        if (materials >= 150)
        {
            FullStorage();
        }
    }

    private void Production()
    {
        materials += Time.deltaTime * (workers + workersSpeed);

        workersEndurance -= Time.deltaTime;
    }

    private void Chill()
    {
        workersEndurance += Time.deltaTime;
    }

    void Sell()
    {
        budget += materials / 10f;
        materials = 0f;

        isSell = false;
    }

    private void BuyNewWorker()
    {
        if (budget > hirePrice)
        {
            workers += 1;
            budget -= hirePrice;

            buyNewWorker = false;
        }
    }

    void BuyNewSoldier()
    {
        if (budget > soldiersHirePrice)
        {
            soldiers++;
            buyNewSoldier = false;
            budget -= soldiersHirePrice;
        }
    }

    void FullStorage()
    {
        isWork = false;
    }
}
