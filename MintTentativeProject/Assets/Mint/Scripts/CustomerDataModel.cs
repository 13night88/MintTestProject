using System;
using System.Collections.Generic;

[Serializable]
public class CustomerDataModel
{
    public string id;
    public string first_name;
    public string last_name;
    public string email;
    public string gender;
    public string ip_address;
    public string address;

    public List<string> Properties = new List<string>();
    public List<string> GetProperties()
    {
        Properties.Add(id);
        Properties.Add(first_name);
        Properties.Add(last_name);
        Properties.Add(email);
        Properties.Add(gender);
        Properties.Add(ip_address);
        Properties.Add(address);
        return Properties;
    }

    public int GetEntityIndex()
    {
        return int.Parse(id);
    }
}

[System.Serializable]
public class CustomerDataModels
{
    public CustomerDataModel[] Items;
}
