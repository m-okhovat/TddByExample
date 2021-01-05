﻿using FluentAssertions;
using TddByExample.Domain;
using Xunit;

namespace TddByExample.Tests.Domain
{
    public class CurrencyTests
    {
        [Fact]
        public void five_dollar_multiplied_multiple_times()
        {
            var fiveDollars = new Dollar(5);

            fiveDollars.Times(2).Should().Be(new Dollar(10));
            fiveDollars.Times(3).Should().Be(new Dollar(15));
        }

        [Fact]
        public void five_dollar_equals_five_dollar()
        {
            var fiveDollar = new Dollar(5);
            var anotherFiveDollar = new Dollar(5);

            fiveDollar.Should().Be(anotherFiveDollar);

            var sixDollar = new Dollar(6);
            var anotherSixDollar = new Dollar(7);

            sixDollar.Should().NotBe(anotherSixDollar);
        }

        [Fact]
        public void define_five_franc()
        {
            const int amount = 6;

            var fiveFranc = new Franc(amount);

            fiveFranc.Should().Be(new Franc(amount));
        }

        [Fact]
        public void multiply_franc()
        {
            var fiveFranc = new Franc(5);

            Franc tenFranc = fiveFranc.Times(2);

            tenFranc.Should().Be(new Franc(10));

            Franc fifteenFranc = fiveFranc.Times(3);

            fifteenFranc.Should().Be(new Franc(15));
        }

        [Fact]
        public void two_franc_with_same_value_are_equal()
        {
            var fiveFranc = new Franc(5);
            var anotherFiveFranc = new Franc(5);

            fiveFranc.Should().Be(anotherFiveFranc);

            var tenFranc = new Franc(10);
            var anotherTenFranc = new Franc(10);

            tenFranc.Should().Be(anotherTenFranc);
        }

        [Fact]
        public void two_franc_with_different_values_are_not_equal()
        {
            var fiveFranc = new Franc(5);
            var eightFranc = new Franc(8);

            fiveFranc.Should().NotBe(eightFranc);
        }

        [Fact]
        public void null_is_not_equal_to_franc()
        {
            var eightFranc = new Franc(8);

            eightFranc.Should().NotBe(null);
        }
    }
}