using CrazyMinnow.SALSA;
using UnityEngine;

/// <summary>
/// This class publish blendshape values computed by SALSA to ROS. 
/// </summary>

public class SalsaVisemeTriggerEventSubscriber : MonoBehaviour
{
	
	[SerializeField] private Salsa salsaInstance;

   



    private void OnEnable()
	{
		Salsa.VisemeTriggered += SalsaOnVisemeTriggered;
	}

	private void OnDisable()
	{
		Salsa.VisemeTriggered -= SalsaOnVisemeTriggered;
	}

	private void SalsaOnVisemeTriggered(object sender, Salsa.SalsaNotificationArgs e)
	{
		if (e.salsaInstance == salsaInstance)
		{
			// TODO here should e.visemeTrigger  & salsaInstance.CachedAnalysisValue be published to ROS
		

			Debug.Log("Viseme (Index) triggered: " + e.visemeTrigger);
            Debug.Log("Cached analysis value: " + salsaInstance.CachedAnalysisValue);
       


        }
	}

   
}
