﻿using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


namespace ShibaInu
{
	/// <summary>
	/// 纯字符串消息协议实现
	/// </summary>
	public class StringMsgProtocol : IMsgProtocol
	{
		public Action<System.Object> messageCallback {
			set { m_responseCallback = value; }
			get { return m_responseCallback; }
		}

		private Action<System.Object> m_responseCallback;

		/// 未解析的数据缓冲
		private byte[] m_buffer = new byte[10240];
		/// 数据缓冲长度
		private int m_length = 0;
		/// 当前已解析位置
		private int m_position = 0;
		/// 当前正在解析的消息长度
		private int m_msgLength = 0;



		public void Receive (byte[] buffer, int length)
		{
			if (buffer != null) {
				m_length += length;
				for (int i = 0; i < length; i++)
					m_buffer [m_position + i] = buffer [i];
			}

			if (m_msgLength == 0) {
				if (m_length - m_position < 4)
					return;

				m_msgLength = BitConverter.ToInt32 (m_buffer, m_position);
				m_position += 4;
			}

			if (m_length - m_position < m_msgLength)
				return;

			string str = Encoding.UTF8.GetString (m_buffer, m_position, m_msgLength);
			m_position += m_msgLength;

			messageCallback (str);

			m_msgLength = 0;
			if (m_position == m_length)
				m_position = m_length = 0;
			else if (m_length - m_position >= 4)
				Receive (null, 0);
		}


		public byte[] Encode (System.Object data)
		{
			byte[] buf = Encoding.UTF8.GetBytes ((string)data);
			byte[] len = BitConverter.GetBytes ((uint)buf.Length);
			byte[] bytes = new byte[buf.Length + len.Length];
			len.CopyTo (bytes, 0);
			buf.CopyTo (bytes, 4);
			return bytes;
		}


		public void Reset ()
		{
		}


		//
	}
}
