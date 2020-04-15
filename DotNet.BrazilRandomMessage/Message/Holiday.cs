using DotNet.BrazilRandomMessage.Message.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet.BrazilRandomMessage.Message
{
    public class Holiday : IMessageBase
    {
        public DateTime FromDate { get; set; } = DateTime.Today;

        public Holiday()
        {

        }

        public Holiday(DateTime _fromDate)
        {
            FromDate = _fromDate;
        }

        public IEnumerable<string> Messages
        {
            get
            {
                var msgs = new Welcome().Messages.ToList();

                if (!FromDateIsHoliday)
                    msgs.ToList();

                switch (FromDateHoliday.HolidayIdentity)
                {
                    case HolidayIdentity.AnoNovo:
                        msgs.AddRange(new List<string>
                        {
                            "Feliz ano novo! 🎉",
                            "Que esse ano seja repleto de felicidade para você!",
                            "Que esse ano seus sonhos se relizem! ;)",
                            "Que esse ano seja repleto de luz e paz para você!"
                        });
                        return msgs;

                    case HolidayIdentity.Tiradentes:
                        msgs.AddRange(new List<string>
                        {
                            "Hj é dia de Tiradentes um grande lider da Inconfidência Mineira"
                        });
                        return msgs;

                    case HolidayIdentity.DiaDoTrabalho:
                        msgs.AddRange(new List<string>
                        {
                            "Hj é dia do trabalho, parabéns a tds trabalhadores! 👷‍♀️"
                        });
                        return msgs;

                    case HolidayIdentity.Independencia:
                        msgs.AddRange(new List<string>
                        {
                            "7 de setembro, Indepência ou morte! ⚔",
                            "Hj é um marco na nossa história, Indepêndencia do Brasil!"
                        });
                        return msgs;

                    case HolidayIdentity.Padroeira:
                        msgs.AddRange(new List<string>
                        {
                            "Hj é dia de Nossa Senhora Aparecida 🙏",
                            "12 de outubro ao 12:00 hrs foi encontrado a nossa rainha 🙏",
                            "Feliz dia das crianças. "
                        });
                        return msgs;

                    case HolidayIdentity.Finados:
                        msgs.AddRange(new List<string>
                        {
                            "Dia de finados, que esteja em paz aqueles que se foram 🙏"
                        });
                        return msgs;

                    case HolidayIdentity.Proclamacao:
                        msgs.AddRange(new List<string>
                        {
                            "Hoje é dia da Proclamação da República"
                        });
                        return msgs;

                    case HolidayIdentity.Natal:
                        msgs.AddRange(new List<string>
                        {
                            "É pavê ou pa comê? 🤦‍♂️",
                            "Ho ho ho Feliz natal! 🎄",
                            "Comemoremos o aniversário de cristo 🙏"
                        });
                        return msgs;

                    case HolidayIdentity.Pascoa:
                        msgs.AddRange(new List<string>
                        {
                            "Hj é o dia da ressureição de Jesus Cristo",
                            "Feliz Páscoa! 🐰"
                        });
                        return msgs;

                    case HolidayIdentity.SextaSanta:
                        msgs.AddRange(new List<string>
                        {
                            "Hj é o dia da Paixão de Cristo 🙏"
                        });
                        return msgs;

                    case HolidayIdentity.Carnaval:
                        msgs.AddRange(new List<string>
                        {
                            "Feliz carnaval!",
                            "Feliz carnaval, comemore com moderação :)"
                        });
                        return msgs;

                    case HolidayIdentity.CorpusChristi:
                        msgs.AddRange(new List<string>
                        {
                            "Tomai e comei, isto é o meu corpo. Mateus 26:26"
                        });
                        return msgs;

                    default:
                        return msgs;
                }
            }
        }

        public Holiday FromDateHoliday => AllHolidays.FirstOrDefault(x => x.Date.Equals(FromDate));

        public bool FromDateIsHoliday => FromDateHoliday != null;

        public DateTime Date { get; set; }

        public HolidayIdentity HolidayIdentity { get; set; }

        public int CurrentYear { get; set; } = DateTime.Today.Year;

        public List<Holiday> AllHolidays
        {
            get
            {
                var list = new List<Holiday>();

                list.AddRange(FixHolidays);
                list.AddRange(MoveHolidays);

                return list;
            }
        }

        public List<Holiday> FixHolidays => new List<Holiday>
        {
            new Holiday { Date = new DateTime(CurrentYear, 1, 1), HolidayIdentity = HolidayIdentity.AnoNovo }, // Ano novo
            new Holiday { Date = new DateTime(CurrentYear, 4, 21), HolidayIdentity = HolidayIdentity.Tiradentes }, // Tiradentes
            new Holiday { Date = new DateTime(CurrentYear, 5, 1), HolidayIdentity = HolidayIdentity.DiaDoTrabalho }, // Dia do trabalho
            new Holiday { Date = new DateTime(CurrentYear, 9, 7), HolidayIdentity = HolidayIdentity.Independencia }, // Indepêndencia do Brasil
            new Holiday { Date = new DateTime(CurrentYear, 10, 12), HolidayIdentity = HolidayIdentity.Padroeira }, // Nossa Senhora Aparecida
            new Holiday { Date = new DateTime(CurrentYear, 11, 2), HolidayIdentity = HolidayIdentity.Finados }, // Finados
            new Holiday { Date = new DateTime(CurrentYear, 11, 15), HolidayIdentity = HolidayIdentity.Proclamacao }, // Proclamação da república
            new Holiday { Date = new DateTime(CurrentYear, 12, 25), HolidayIdentity = HolidayIdentity.Natal } // Natal
        };

        public List<Holiday> MoveHolidays
        {
            get
            {
                var holidayList = FixHolidays;

                int x, y, a, b, c, d, e, day, month;

                if (CurrentYear >= 1900 & CurrentYear <= 2099)
                {
                    x = 24;
                    y = 5;
                }

                else if (CurrentYear >= 2100 & CurrentYear <= 2199)
                {
                    x = 24;
                    y = 6;
                }

                else if (CurrentYear >= 2200 & CurrentYear <= 2299)
                {
                    x = 25;
                    y = 7;
                }

                else
                {
                    x = 24;
                    y = 5;
                }

                a = CurrentYear % 19;
                b = CurrentYear % 4;
                c = CurrentYear % 7;
                d = (19 * a + x) % 30;
                e = (2 * b + 4 * c + 6 * d + y) % 7;

                if ((d + e) > 9)
                {
                    day = (d + e - 9);
                    month = 4;
                }

                else
                {
                    day = (d + e + 22);
                    month = 3;
                }

                var pascoa = new DateTime(CurrentYear, month, day);
                var sextaSanta = pascoa.AddDays(-2);
                var carnaval = pascoa.AddDays(-47);
                var corpusChristi = pascoa.AddDays(60);

                holidayList.Add(new Holiday { Date = pascoa, HolidayIdentity = HolidayIdentity.Pascoa });
                holidayList.Add(new Holiday { Date = sextaSanta, HolidayIdentity = HolidayIdentity.SextaSanta });
                holidayList.Add(new Holiday { Date = carnaval, HolidayIdentity = HolidayIdentity.Carnaval });
                holidayList.Add(new Holiday { Date = corpusChristi, HolidayIdentity = HolidayIdentity.CorpusChisti });

                return holidayList;
            }
        }
    }

    public enum HolidayIdentity
    {
        AnoNovo,
        Tiradentes,
        DiaDoTrabalho,
        Independencia,
        Padroeira,
        Finados,
        Proclamacao,
        Natal,
        Pascoa,
        SextaSanta,
        Carnaval,
        CorpusChristi
    }
}
