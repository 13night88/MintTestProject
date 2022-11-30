using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPorts<T>
{
    public T LoadData();
    public void SaveData(T Data);
}
