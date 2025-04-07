// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Ledger.Domain.Accounts;

public sealed class Account
{
	public Account                     Parent   { get; private set; }
	public Dictionary<string, Account> Children { get; private set; }
	public List<Post> 		  Posts    { get; private set; }

	public string Name { get; private set; }
	public string Note { get; set; }
	public Account(string accountName, decimal balance) { }
}
