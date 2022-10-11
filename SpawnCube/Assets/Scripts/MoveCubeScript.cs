using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeScript : MonoBehaviour
{
    private float mSpeed = 0f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        setSpeed();
        listenDistance();
    }

    private void setSpeed()
    {
        mSpeed = getSpeedValue();
        if (mSpeed > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * mSpeed);
        }
    }

    private void listenDistance()
    {
        if (Vector3.Distance(startPosition, transform.position) >= getDestroyDistanceValue())
        {
            Destroy(gameObject);
        }
    }

    private float getSpeedValue()
    {
        return getPlayerPref("CubeSpeed");
    }

    private float getDestroyDistanceValue()
    {
        return getPlayerPref("DestroyDistance");
    }

    private float getPlayerPref(string nameKey)
    {
        if (PlayerPrefs.HasKey(nameKey))
        {
            return PlayerPrefs.GetFloat(nameKey);
        }
        else return 0f;
    }
}
