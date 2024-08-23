﻿using System;

namespace Cpp2ILInjected.CallAnalysis
{
	// Token: 0x0200000F RID: 15
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class CallsAttribute : Attribute
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0000207A File Offset: 0x0000027A
		public CallsAttribute()
		{
			throw null;
		}

		// Token: 0x0400000F RID: 15
		public object Type;

		// Token: 0x04000010 RID: 16
		public string Member;

		// Token: 0x04000011 RID: 17
		public object[] MemberTypeParameters;

		// Token: 0x04000012 RID: 18
		public object[] MemberParameters;

		// Token: 0x04000013 RID: 19
		public object ReturnType;
	}
}
