using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class SetDataScript : MonoBehaviour
{
    public void onChangeSpawnRateData()
    {
        onSavePlayerPrefs("SpawnRate", gameObject.GetComponent<Slider>().value);
    }

    public void onChangeCubeSpeedData()
    {
        onSavePlayerPrefs("CubeSpeed", gameObject.GetComponent<Slider>().value);
    }

    public void onChangeDestroyDistanceData()
    {
        onSavePlayerPrefs("DestroyDistance", gameObject.GetComponent<Slider>().value);
    }

    private void onSavePlayerPrefs(string nameKey, float sliderValue)
    {
        PlayerPrefs.SetFloat(nameKey, sliderValue);
        PlayerPrefs.Save();
    }
}
