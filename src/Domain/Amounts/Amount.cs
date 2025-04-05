// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.Apache License, Version 2.0

namespace Wangkanai.Ledger.Domain.Amounts;

public class Amount : IEquatable<Amount>
{
	public Amount() { }

	public bool Equals(Amount? other)
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
		return Equals((Amount)obj);
	}

	public override int GetHashCode()
	{
		throw new NotImplementedException();
	}
}
