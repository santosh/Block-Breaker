using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public Sprite[] hitSprites;

    private int timesHit;
    private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col) {
        bool isBreakable = (this.tag == "Breakable");
        HandleHits();
    }

    void HandleHits() {
        timesHit++;
        // take maxHits from hitSprites length we set in editor
        int maxHits = hitSprites.Length + 1;
        Debug.Log("Times hit count: " + timesHit + " Max: " + maxHits);
        if (timesHit >= maxHits) {
            Destroy(gameObject);
        } else {
            LoadSprites();
        }
    }

    void LoadSprites() {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex]) {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }
}
