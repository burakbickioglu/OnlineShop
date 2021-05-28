﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Core.Utils.XmlKur
{
    public class kurManager
    {

        public string kurGetir(string dovizAd)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDosya = new XmlDocument();
            xmlDosya.Load(bugun);

            string satisFiyati = xmlDosya.SelectSingleNode($"Tarih_Date/Currency[@Kod='{dovizAd}']/BanknoteBuying")
                .InnerXml;


            return satisFiyati;

        }
    }
}
