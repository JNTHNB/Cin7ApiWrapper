using Cin7ApiWrapper.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class QueryBuilderTests
    {
        [Test]
        public void ValidateWhereClause_WithModifiedDate()
        {
            var date = new DateTime(2019, 05, 01, 0, 0, 0, DateTimeKind.Utc);

            string actual = new QueryBuilder(modifiedSince: date).Query;
            string expected = string.Format("where=modifieddate>'{0:yyyy-MM-ddTHH:mm:ssZ}'", date);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("firstname like 'jon%'")]
        [TestCase("total >= 100 and total < 1000")]
        public void ValidateWhereClause(string where)
        {
            string actual = new QueryBuilder(where: where).Query;
            string expected = "where=" + where;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddWhereConditions()
        {
            var qb = new QueryBuilder();
            var conditions = new List<string>() {
                "reference like '%PO-%'",
                "total >= 100",
                "total < 1000"
            };

            foreach (string c in conditions)
                qb.AddWhereCondition(c);

            string actual = qb.Where;
            string expected = string.Join(" and ", conditions);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddWhereConditionWithExistingCondition_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var qb = new QueryBuilder();
                qb.AddWhereCondition("1=1");
                qb.AddWhereCondition("1=1");
            });
        }
    }
}