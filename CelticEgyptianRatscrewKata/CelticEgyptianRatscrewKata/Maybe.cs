using System;
using System.Collections.Generic;

namespace CelticEgyptianRatscrewKata
{
    public struct Maybe<T> : IEquatable<Maybe<T>> where T : class
    {

        private readonly bool _hasValue;
        private readonly T _value;

        public static readonly Maybe<T> Nothing = new Maybe<T>(false, default(T));
        
        public static implicit operator Maybe<T>(T value)
        {
            if (value == null) throw new ArgumentNullException("value");
            return new Maybe<T>(true, value);
        }
        
        private Maybe(bool hasValue, T value)
        {
            _hasValue = hasValue;
            _value = value;
        }

        #region Equality Members
        public bool Equals(Maybe<T> other)
        {
            return EqualityComparer<T>.Default.Equals(_value, other._value) && _hasValue.Equals(other._hasValue);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Maybe<T> && Equals((Maybe<T>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (EqualityComparer<T>.Default.GetHashCode(_value) * 397) ^ _hasValue.GetHashCode();
            }
        }

        public static bool operator ==(Maybe<T> left, Maybe<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Maybe<T> left, Maybe<T> right)
        {
            return !left.Equals(right);
        }
        #endregion
    }
}