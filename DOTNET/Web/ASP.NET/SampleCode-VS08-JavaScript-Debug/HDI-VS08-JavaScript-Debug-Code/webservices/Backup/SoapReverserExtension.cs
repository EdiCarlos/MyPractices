using System.Web.Services.Protocols;
using System.IO;
using System;
using System.Reflection;

namespace SoapReverserExtensionLib
{
	[AttributeUsage(AttributeTargets.Method)]
	public class ReverserExtensionAttribute : SoapExtensionAttribute 
	{
		private string filename = "log";
		private int priority;

		public override Type ExtensionType 
		{
			get { return typeof(ReverserExtensionAttribute); }
		}

		public override int Priority 
		{
			get { return priority; }
			set { priority = value; }
		}

		public string Filename 
		{
			get 
			{
				return filename;
			}
			set 
			{
				filename = value;
			}
		}
	}
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class SoapReverserExtension : SoapExtension
	{
		Stream _workingStream;
		Stream _originalStream;
		string _fileName;

		public SoapReverserExtension()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public override Stream ChainStream( Stream stream )
		{
			// Save the passed in Stream in a member variable.
			_originalStream = stream;

			// Create a new instance of a Stream and save that in 
			/// a member variable.
			_workingStream = new MemoryStream();
			return _workingStream;
		}

		public override object GetInitializer(
			LogicalMethodInfo methodInfo,
			SoapExtensionAttribute attribute) 
		{
			return ((ReverserExtensionAttribute) attribute).Filename;
		}

		public override void Initialize(object initializer) 
		{
			// For security reasons, if _fileName can come from an untrusted source, 
			// it should be validated before being used.
			_fileName = (string) initializer;
		}

		public override object GetInitializer(Type WebServiceType) 
		{
			// Return a file name to log the trace information, based on the type.
			return "C:\\" + WebServiceType.FullName + ".log";
		}

		public override void ProcessMessage(SoapMessage message) 
		{
			//	bool bIsServer;
			//	if(message.GetType() == typeof(SoapServerMessage))
			//	{
			//		bIsServer = true;
			//	} 
			//	else
			//	{
			//		bIsServer = false;
			//	}

			switch (message.Stage) 
			{
				// Incomming from client
				case SoapMessageStage.BeforeDeserialize:
					ReceiveStream();
					ReverseIncomingStream();
					LogInput(message);
					break;

				// About to call methods
				case SoapMessageStage.AfterDeserialize:
					break;

				// After Method call
				case SoapMessageStage.BeforeSerialize:
					break;

				// Outgoing to client
				case SoapMessageStage.AfterSerialize:
					ReverseOutgoingStream();
					LogOutput(message);
					ReturnStream();
					break;
				default:
					throw new Exception("No stage such as this...");
			}
		}

		public void ReturnStream()
		{
			// _workingStream contains the message going
			// back to the other endpoint
			Copy(_workingStream, _originalStream);
		}

		public void LogOutput(SoapMessage message)
		{
			_workingStream.Position = 0;
			FileStream fs = new FileStream(_fileName, 
				FileMode.Append,
				FileAccess.Write);
			StreamWriter w = new StreamWriter(fs);

			string soapString = (message is SoapServerMessage) ? "SoapResponse" : "SoapRequest";
			w.WriteLine("-----" + soapString + " at " + DateTime.Now);
			w.Flush();

			Copy(_workingStream, fs);
			w.Close();
			_workingStream.Position = 0;
			// ReturnStream must be called
		}

		void ReceiveStream()
		{
			// _originalStream has input from 
			//   other endpoint
			Copy(_originalStream, _workingStream);
		}

		public void LogInput(SoapMessage message)
		{
			// Must have called ReceiveStream by this point.

			FileStream fs = new FileStream(_fileName, 
				FileMode.Append,
				FileAccess.Write);
			StreamWriter w = new StreamWriter(fs);

			string soapString = (message is SoapServerMessage) ?
				"SoapRequest" : "SoapResponse";
			w.WriteLine("-----" + soapString + 
				" at " + DateTime.Now);
			w.Flush();
			_workingStream.Position = 0;
			Copy(_workingStream, fs);
			w.Close();
			_workingStream.Position = 0;
		}

		public void ReverseStream(Stream stream)
		{
			TextReader tr = new StreamReader(stream);
			string str = tr.ReadToEnd();
			char[] data = str.ToCharArray();
			Array.Reverse(data);
			string strReversed = new string(data);

			TextWriter tw = new StreamWriter(stream);
			stream.Position = 0;
			tw.Write(strReversed);
			tw.Flush();
		}

		public void ReverseIncomingStream()
		{
			ReverseStream(_workingStream);
		}

		public void ReverseOutgoingStream()
		{
			ReverseStream(_workingStream);
		}

		void Copy(Stream from, Stream to) 
		{
			TextReader reader = new StreamReader(from);
			TextWriter writer = new StreamWriter(to);
			writer.WriteLine(reader.ReadToEnd());
			writer.Flush();
		}
	}
}
