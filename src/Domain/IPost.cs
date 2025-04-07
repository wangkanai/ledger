// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

using Wangkanai.Ledger.Domain.Accounts;
using Wangkanai.Ledger.Domain.Amounts;

namespace Wangkanai.Ledger.Domain;

public interface IPost
{
	Account Account        { get; set; }
	Amount  Amount         { get; set; }
	Amount  AssignedAmount { get; set; }
	Amount  Cost           { get; set; }
	Amount  GivenCost      { get; set; }
}
