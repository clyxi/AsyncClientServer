﻿using System;
using System.Collections.Generic;
using AsyncClientServer.Model;

namespace AsyncClientServer.Helper
{
	/// <summary>
	/// Interface for AsyncSocketListener
	/// <para>Implements <seealso cref="IDisposable"/></para>
	/// </summary>
	public interface IAsyncSocketListener : IDisposable
	{
		event MessageReceivedHandler MessageReceived;

		event MessageSubmittedHandler MessageSubmitted;

		event ObjectReceivedHandler ObjectReceived;

		event ClientDisconnectedHandler ClientDisconnected;

		void StartListening();

		bool IsConnected(int id);

		void OnClientConnect(IAsyncResult result);

		void ReceiveCallback(IAsyncResult result);

		IDictionary<int, IStateObject> GetClients();

		void Close(int id);

	}
}
