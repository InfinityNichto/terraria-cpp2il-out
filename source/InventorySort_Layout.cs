﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001DD")]
public class InventorySort_Layout : PageControllerLayoutDefinition<InventorySort_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C43")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAC2C", Offset = "0x9CAC2C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public InventorySort_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001114")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout InventorySort;

	[global::Cpp2ILInjected.Token(Token = "0x4001115")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout InventorySort_Horizontal;
}
