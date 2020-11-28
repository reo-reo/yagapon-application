using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MakeRadarChart : MonoBehaviour {


	public GameObject rcp;
	public GameObject dir;

	// Use this for initialization
	void Start () {
		int i;
		for(i = 0; i < 5; i++){
			rcp.GetComponent<RadarChartPolygonUGUI>().Volumes[i] = dir.GetComponent<Director>().result[i]/5f;
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
