using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortudo.Tests
{
    public class SortudoTests
    {
        [TestFixture]
        public class SortudoCasosDeTestes
        {
            [Test]
            public void EhSortudo7()
            {
                int num;
                num = 7;
                int[] sorte = new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99 };
                Assert.That((sorte.Contains(num)), Is.EqualTo(true));
            }

            [Test]
            public void EhSortudo21()
            {
                int num;
                num = 21;
                int[] sorte = new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99 };
                Assert.That((sorte.Contains(num)), Is.EqualTo(true));
            }

            [Test]
            public void NaoEhSortudo28()
            {
                int num;
                num = 28;
                int[] sorte = new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99 };
                Assert.That((sorte.Contains(num)), Is.EqualTo(false));
            }

            [Test]
            public void NaoEhSortudo142()
            {
                int num;
                num = 142;
                int[] sorte = new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99 };
                Assert.That((sorte.Contains(num)), Is.EqualTo(false));
            }

            [Test]
            public void EhSortudo37()
            {
                int num;
                num = 37;
                int[] sorte = new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99 };
                Assert.That((sorte.Contains(num)), Is.EqualTo(true));
            }

            [Test]
            public void NaoEhSortudo100()
            {
                int num;
                num = 100;
                int[] sorte = new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99 };
                Assert.That((sorte.Contains(num)), Is.EqualTo(false));
            }
        }
    }
}

