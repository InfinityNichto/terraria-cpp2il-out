﻿using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000C RID: 12
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class CallAnalysisNotSupportedAttribute : Attribute
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002071 File Offset: 0x00000271
		public CallAnalysisNotSupportedAttribute()
		{
			throw null;
		}
	}
}
