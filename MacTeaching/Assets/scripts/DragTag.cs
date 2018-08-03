using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragTag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

	private Image image;
	private Vector3 position;

	private void Awake()
	{	//JsonConvert.DeserializeObject(); //json Decode C#
		image = GetComponent<Image>();
		position = transform.position;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		image.color = Color.green;
	}

	public void OnDrag(PointerEventData eventData)
	{
		transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		image.color = Color.white;
		transform.position = this.position;
	}
}