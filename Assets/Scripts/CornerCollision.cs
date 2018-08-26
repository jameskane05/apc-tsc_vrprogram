using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CornerCollision : MonoBehaviour
{

    public int cornerNum;

    private void OnTriggerEnter(Collider other)
    {
        ExperimentSettings _expInstance = ExperimentSettings.GetInstance();
        if (ExperimentSettings.IsTSC())
        {
            Debug.Log(gameObject.transform.position);
            MazeController.cornerTransform = gameObject.transform;
            gameObject.SetActive(false);
            //Debug.Log(gameObject.ToString());
            MazeController.onCorner = cornerNum;
            GameObject landmarkList = GameObject.Find("LandmarkList");
            Transform landmarkNameTransform = landmarkList.transform.GetChild(cornerNum);
            if (cornerNum > 0)
            {
                Transform lastLandmarkNameTransform = landmarkList.transform.GetChild(cornerNum - 1);
                Text lastLandmarkNameText = lastLandmarkNameTransform.GetComponent<Text>();
                lastLandmarkNameText.fontSize = 14;
                lastLandmarkNameText.fontStyle = FontStyle.Normal;
            }
            Text landmarkNameText = landmarkNameTransform.GetComponent<Text>();
            landmarkNameText.fontSize = 20;
            landmarkNameText.fontStyle = FontStyle.Bold;

        }

    }


}
