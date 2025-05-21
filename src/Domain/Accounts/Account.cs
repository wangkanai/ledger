// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Ledger.Domain.Accounts;

public sealed class Account
{
	private Account()
	{
		Children = new SortedDictionary<string, Account>();
		Posts    = new List<Post>();
	}

	public Account(string name, string note) : this()
	{
		Depth = 0;
		Name  = name;
		Note  = note;
	}

	public Account(Account parent, string name, string note) : this(name, note)
	{
		Parent = parent;
		Depth  = parent.Depth + 1;
	}

	public Account? Parent { get; private set; }
	public string   Name   { get; private set; } = null!;
	public string   Note   { get; set; }         = null!;
	public int      Depth  { get; private set; }

	public IDictionary<string, Account> Children { get; private set; }

	public IList<Post> Posts { get; private set; }
}
