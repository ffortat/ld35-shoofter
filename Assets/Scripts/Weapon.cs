﻿using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	public Transform[] m_weapons;
	public Transform m_ammunition;
	public float m_cooldown = 1f;

	private float m_timer = 0f;

	// Use this for initialization
	void Start () {
		//foreach (GameObject weapon in GameObject.FindGameObjectsWithTag("Weapon")) {
		//	m_weapons[m_weapons.Length] = weapon.transform;
		//}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Shoot(bool fire) {
		if (fire) {
			if (m_timer >= m_cooldown) {
				m_timer = 0f;

				foreach (Transform weapon in m_weapons) {
					Transform ammo = (Transform) Instantiate(m_ammunition);
					ammo.parent = GameObject.Find(weapon.name).transform;
					ammo.localPosition = Vector3.zero;

					ammo.parent = null;
				}
			}
		}

		m_timer += Time.deltaTime;
	}
}