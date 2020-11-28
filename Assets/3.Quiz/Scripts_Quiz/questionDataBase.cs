using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "questionDataBase", menuName = "CreateQuestionDataBase")]
public class questionDataBase :  ScriptableObject{

	[SerializeField]
	private List<Quiz> quizLists = new List<Quiz>();

	public void shuffle(){
		quizLists = quizLists.OrderBy(a => Guid.NewGuid()).ToList();
	}

	public List<Quiz> getQuizLists(){
		return quizLists;
	}
}
