﻿using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

    public int scorePerHit = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        var scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreKeeper.IncrementTheScore(scorePerHit);
    }
}
