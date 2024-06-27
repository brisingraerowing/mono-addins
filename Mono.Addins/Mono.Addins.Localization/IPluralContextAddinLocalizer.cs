using System;
using System.Collections.Generic;
using System.Text;

namespace Mono.Addins.Mono.Addins.Localization
{
	/// <summary>
	/// 
	/// </summary>
	public interface IPluralContextAddinLocalizer
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		/// <param name="msgid"></param>
		/// <param name="msgidPlural"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		string GetParticularPluralString(string context, string msgid, string msgidPlural, int n);

	}
}
