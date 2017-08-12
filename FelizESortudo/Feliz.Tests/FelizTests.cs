using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feliz.Tests
{
    public class FelizTests
    {
        [TestFixture]
        public class FelizCasosDeTestes
        {
            [Test]
            public void EhFeliz7()
            {
                int num;
                num = 7;
                {
                    var verifica = new Dictionary<int, bool>();
                    var felicidade = num;

                    while (!verifica.ContainsKey(felicidade))
                    {
                        verifica.Add(felicidade, true);
                        var start = felicidade;
                        felicidade = 0;
                        while (start != 0)
                        {
                            felicidade += (start % 10) * (start % 10);
                            start /= 10;
                        }
                    }
                    Assert.That((felicidade == 1), Is.EqualTo(true));
                }
            }

            [Test]
            public void NaoEhFeliz21()
            {
                int num;
                num = 21;
                {
                    var verifica = new Dictionary<int, bool>();
                    var felicidade = num;

                    while (!verifica.ContainsKey(felicidade))
                    {
                        verifica.Add(felicidade, true);
                        var start = felicidade;
                        felicidade = 0;
                        while (start != 0)
                        {
                            felicidade += (start % 10) * (start % 10);
                            start /= 10;
                        }
                    }
                    Assert.That((felicidade != 1), Is.EqualTo(true));
                }
            }

            [Test]
            public void EhFeliz28()
            {
                int num;
                num = 28;
                {
                    var verifica = new Dictionary<int, bool>();
                    var felicidade = num;

                    while (!verifica.ContainsKey(felicidade))
                    {
                        verifica.Add(felicidade, true);
                        var start = felicidade;
                        felicidade = 0;
                        while (start != 0)
                        {
                            felicidade += (start % 10) * (start % 10);
                            start /= 10;
                        }
                    }
                    Assert.That((felicidade == 1), Is.EqualTo(true));
                }
            }

            [Test]
            public void NaoEhFeliz142()
            {
                int num;
                num = 142;
                {
                    var verifica = new Dictionary<int, bool>();
                    var felicidade = num;

                    while (!verifica.ContainsKey(felicidade))
                    {
                        verifica.Add(felicidade, true);
                        var start = felicidade;
                        felicidade = 0;
                        while (start != 0)
                        {
                            felicidade += (start % 10) * (start % 10);
                            start /= 10;
                        }
                    }
                    Assert.That((felicidade != 1), Is.EqualTo(true));
                }
            }

            [Test]
            public void NaoEhFeliz37()
            {
                int num;
                num = 37;
                {
                    var verifica = new Dictionary<int, bool>();
                    var felicidade = num;

                    while (!verifica.ContainsKey(felicidade))
                    {
                        verifica.Add(felicidade, true);
                        var start = felicidade;
                        felicidade = 0;
                        while (start != 0)
                        {
                            felicidade += (start % 10) * (start % 10);
                            start /= 10;
                        }
                    }
                    Assert.That((felicidade != 1), Is.EqualTo(true));
                }
            }

            [Test]
            public void EhFeliz100()
            {
                int num;
                num = 100;
                {
                    var verifica = new Dictionary<int, bool>();
                    var felicidade = num;

                    while (!verifica.ContainsKey(felicidade))
                    {
                        verifica.Add(felicidade, true);
                        var start = felicidade;
                        felicidade = 0;
                        while (start != 0)
                        {
                            felicidade += (start % 10) * (start % 10);
                            start /= 10;
                        }
                    }
                    Assert.That((felicidade == 1), Is.EqualTo(true));
                }
            }
        }
    }
}

