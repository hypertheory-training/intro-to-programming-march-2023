using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.BonusCalculator;
    public class BonusCalculator
    {
    //deposit that meet criteria get a bonus
    [Fact]
    public void DepositThatMeetCriteriaCalculator()
    {
        var bonusCalculator = new StandardBonusCalculator();

        decimal bonus = bonusCalculator.CalculatebankAccountDepositBonusFor(500M, 100M);

        Assert.Equal(10M, bonus);
    }

    //deposit that do not meet the criteria do not get a bonus
}
