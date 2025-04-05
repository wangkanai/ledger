// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Ledger.Domain;

public class Balance : IEquatable<Balance>
{
	public Balance() { }

	public bool Equals(Balance? other)
	{
		throw new NotImplementedException();
	}

	public override bool Equals(object? obj)
	{
		if (obj is null)
			return false;
		if (ReferenceEquals(this, obj))
			return true;
		if (obj.GetType() != GetType())
			return false;
		return Equals((Balance)obj);
	}

	public override int GetHashCode()
	{
		throw new NotImplementedException();
	}
}
