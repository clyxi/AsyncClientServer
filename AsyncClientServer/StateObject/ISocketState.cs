﻿using System.Collections.Generic;
using System.Net.Security;
using System.Net.Sockets;
using AsyncClientServer.StateObject.MessageHandlerState;

namespace AsyncClientServer.StateObject
{
	/// <summary>
	/// Interface for stateobject
	/// </summary>
	public  interface ISocketState
	{
		/// <summary>
		/// Get the buffersize
		/// </summary>
		int BufferSize { get; }

		string RemoteIPv4 { get;}
		string RemoteIPv6 { get; }

		string LocalIPv4 { get; }
		string LocalIPv6 { get; }

		/// <summary>
		/// Get or set the size of the message
		/// </summary>
		int MessageSize { get; set; }

		int UnhandledBytes { get; set; }

		/// <summary>
		/// Get or set the SslStream
		/// </summary>
		SslStream SslStream { get; set; }

		/// <summary>
		/// Get or set the size of the header of the current message
		/// </summary>
		int HeaderSize { get; set; }

		/// <summary>
		/// get how much bytes have been read.
		/// </summary>
		int Read { get; }

		/// <summary>
		/// The flag of the stateObject, used to check  in which state the object is.
		/// </summary>
		int Flag { get; set; }

		/// <summary>
		/// The header of the message currently receiving.
		/// </summary>
		string Header { get; set; }

		/// <summary>
		/// True if the bytes are encrypted.
		/// </summary>
		bool Encrypted { get; set; }

		/// <summary>
		/// The id of the state
		/// </summary>
		int Id { get; }

		/// <summary>
		/// If the state should be closed after this message
		/// </summary>
		bool Close { get; set; }

		/// <summary>
		/// Gets the buffer
		/// </summary>
		byte[] Buffer { get; }

		/// <summary>
		/// The listener socket
		/// </summary>
		Socket Listener { get; }

		/// <summary>
		/// Append byte
		/// </summary>
		/// <param name="length"></param>
		void AppendRead(int length);

		/// <summary>
		/// Subtract from bytes
		/// </summary>
		/// <param name="length"></param>
		void SubtractRead(int length);

		/// <summary>
		/// Change the value of the buffer
		/// </summary>
		/// <param name="newBuffer"></param>
		void ChangeBuffer(byte[] newBuffer);

		/// <summary>
		/// The current state object.
		/// </summary>
		SocketStateState CurrentState { get; set; }

		/// <summary>
		/// Reset the current state object.
		/// </summary>
		void Reset();


		/// <summary>
		/// Gets how much bytes have been received
		/// </summary>
		byte[] ReceivedBytes { get; }

		/// <summary>
		/// Append the bytes to the state.
		/// </summary>
		/// <param name="bytes"></param>
		void AppendBytes(byte[] bytes);


	}
}
