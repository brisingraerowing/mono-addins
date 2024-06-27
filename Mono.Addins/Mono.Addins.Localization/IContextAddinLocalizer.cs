using System;
using System.Collections.Generic;
using System.Text;

namespace Mono.Addins.Mono.Addins.Localization
{
	/// <summary>
	/// 
	/// </summary>
	public interface IContextAddinLocalizer
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		/// <param name="msgid"></param>
		/// <returns></returns>
		string GetParticularString(string context, string msgid);

	}
}
