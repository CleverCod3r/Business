using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine;

public class FactoryStatistics : MonoBehaviour
{
    public Factory FactoryScript;

    public TextMeshProUGUI _workers;
    public TextMeshProUGUI _materials;
    public TextMeshProUGUI _endurance;
    public TextMeshProUGUI _budget;

    public GameObject factoryStatistics;

    public Button openFS;
    public Button closeFS;

    private void Start()
    {
        _workers.text = FactoryScript.workers.ToString();
        _materials.text = FactoryScript.materials.ToString();
        _endurance.text = FactoryScript.workersEndurance.ToString();
        _budget.text = FactoryScript.budget.ToString();
    }

    private void Update()
    {
        _workers.text = Mathf.Round(FactoryScript.workers).ToString();
        _materials.text = Mathf.Round(FactoryScript.materials).ToString();
        _endurance.text = Mathf.Round(FactoryScript.workersEndurance).ToString();
        _budget.text = Mathf.Round(FactoryScript.budget).ToString();
    }


    public void FactoryStatisticsOpen()
    {
        factoryStatistics.SetActive(true);
        closeFS.gameObject.SetActive(true);
        openFS.gameObject.SetActive(false);
    }

    public void FactoryStatisticsClose()
    {
        factoryStatistics.SetActive(false);
        closeFS.gameObject.SetActive(false);
        openFS.gameObject.SetActive(true);
    }
}
