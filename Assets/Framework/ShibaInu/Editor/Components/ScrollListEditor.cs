﻿using System;
using UnityEngine;
using UnityEditor;


namespace ShibaInu
{
	[CustomEditor (typeof(ScrollList))]
	public class ScrollListEditor : BaseListEditor
	{
		
		protected SerializedProperty m_viewportSize;

		protected GUIContent m_c_direction = new GUIContent ("Direction", "滚动方向");
		protected GUIContent m_c_horizontal = new GUIContent ("Horizontal", "水平");
		protected GUIContent m_c_vertical = new GUIContent ("Vertical", "垂直");
		protected GUIContent m_c_viewportSize = new GUIContent ("Viewport Size", "显示范围 [ 宽, 高 ]");

		protected ScrollList m_scrollList;



		protected override void OnEnable ()
		{
			base.OnEnable ();

			m_scrollList = (ScrollList)target;

			m_viewportSize = serializedObject.FindProperty ("m_viewportSize");
		}


		public override void OnInspectorGUI ()
		{
			base.OnInspectorGUI ();

			// direction
			EditorGUILayout.BeginHorizontal ();
			EditorGUILayout.LabelField (m_c_direction, m_labelWidth);
			bool isVertical = m_scrollList.isVertical;
			bool isH = GUILayout.Toggle (!isVertical, m_c_horizontal, m_halfWidth);
			bool isV = GUILayout.Toggle (isVertical, m_c_vertical, m_halfWidth);
			if (isVertical) {
				if (isH) {
					m_scrollList.isVertical = false;
					MarkSceneDirty ();
				}
			} else {
				if (isV) {
					m_scrollList.isVertical = true;
					MarkSceneDirty ();
				}
			}
			EditorGUILayout.EndHorizontal ();
			m_rowCountDisabled = m_scrollList.isVertical;
			m_columnCountDisabled = !m_scrollList.isVertical;


			// viewport size
			EditorGUILayout.BeginHorizontal ();
			EditorGUILayout.LabelField (m_c_viewportSize, m_labelWidth);
			Vector2 viewportSize = m_viewportSize.vector2Value;
			int vpw = EditorGUILayout.IntField ((int)viewportSize.x, m_halfWidth);
			int vph = EditorGUILayout.IntField ((int)viewportSize.y, m_halfWidth);
			MarkSceneDirty (vpw != viewportSize.x || vph != viewportSize.y);
			m_scrollList.SetViewportSize ((uint)(vpw < 0 ? 0 : vpw), (uint)(vph < 0 ? 0 : vph));
			EditorGUILayout.EndHorizontal ();


			serializedObject.ApplyModifiedProperties ();
		}


		//
	}
}

