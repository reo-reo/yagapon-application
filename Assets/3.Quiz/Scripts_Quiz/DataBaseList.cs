using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "DataBaseList", menuName = "CreateDataBaseList")]
public class DataBaseList :  ScriptableObject{

	[SerializeField]
	private List<questionDataBase> dbList = new List<questionDataBase>();

	public void dbShuffle(){
		dbList = dbList.OrderBy(a => Guid.NewGuid()).ToList();
	}

	public questionDataBase getDataBaseList(int num){
		return dbList [num];
	}
}
