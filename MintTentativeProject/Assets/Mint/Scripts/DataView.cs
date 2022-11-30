using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI[] TextFields;

    [SerializeField]
    TextMeshProUGUI log;

    private CustomerDataModels loadedEntities;

    private IDataPorts<CustomerDataModels> jsonLoader = new JsonLoader();

    private List<string> properties = new List<string>();

    public static TextAsset jsonData;

    void Start()
    {
        loadedEntities =  jsonLoader.LoadData();
    }

    private void Update()
    {
        properties = loadedEntities.Items[DataController.CurrentCardId].GetProperties();

        DisplayData(properties);
        
    }



    private void DisplayData(List<string> properties)
    {
        for (int i = 0; i < TextFields.Length; i++)
        {           
            TextFields[i].text = properties[i+1];
        }
    }
}
