// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Ledger.Domain.Accounts;
using Wangkanai.Ledger.Domain.Amounts;

namespace Wangkanai.Ledger.Domain;

public class Post: IPost
{
	public Account Account        { get; set; }
	public Amount  Amount         { get; set; }
	public Amount  AssignedAmount { get; set; }
	public Amount  Cost           { get; set; }
	public Amount  GivenCost      { get; set; }

}
