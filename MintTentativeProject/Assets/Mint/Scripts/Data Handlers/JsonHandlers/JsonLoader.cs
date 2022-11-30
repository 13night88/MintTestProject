using UnityEngine;

public class JsonLoader : IDataPorts<CustomerDataModels>
{
    public CustomerDataModels LoadedEntities;

    private string fileName = Mint.Constants.TEST_DATA_FILE_NAME;

    public string filePath;
    public CustomerDataModels LoadData()
    {
        TextAsset jsonData = Resources.Load<TextAsset>(fileName) as TextAsset;

        Debug.Log(jsonData); 

        LoadedEntities = JsonUtility.FromJson<CustomerDataModels>("{\"Items\":" + jsonData+"}");

        DataController.CustomerEntitiesLenght = LoadedEntities.Items.Length;

        return LoadedEntities;

    }

    public void SaveData(CustomerDataModels Data)
    {

    }
}




