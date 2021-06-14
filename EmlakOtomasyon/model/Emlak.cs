using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EmlakOtomasyon.Enums;

namespace EmlakOtomasyon.model
{
    public class Emlak
    {
        public int Oda { get; set; }
        public int Salon { get; set; }
    
        public TypeOfHeating IsitmaTipi { get; set; }
        public HomeTypeEnum Tipi { get; set; }
        public HomeStatus Durumu { get; set; }
        public string Fiyat { get; set; }

        private int _IlanNo;
        public int IlanNo
        {
            get
            {
                return _IlanNo;
            }
            set
            {
                if (value < 0)
                {
                    _IlanNo = 0;
                }
                else
                {
                    _IlanNo = value;
                }
            }
        }

        public Emlak()
        {

        }
        public Emlak(int oda, int salon, TypeOfHeating isinma, HomeStatus evDurumu, int ilanNo, string fiyat, HomeTypeEnum tipi)
        {
            Oda = oda;
            Salon = salon;
            IsitmaTipi = isinma;
            Tipi = tipi;
            Durumu = evDurumu;
            IlanNo = ilanNo;
            Fiyat = fiyat;
        }
    }

    public class MustakilEv : Emlak
    {
        public MustakilEv(int oda, int salon, TypeOfHeating isinma, HomeStatus evDurumu, int ilanNo, string fiyat, HomeTypeEnum tipi, bool bahce, bool garaj) : base(oda, salon, isinma, evDurumu, ilanNo, fiyat, tipi)
        {
            Oda = oda;
            Salon = salon;
            IsitmaTipi = isinma;
            Tipi = tipi;
            Durumu = evDurumu;
            IlanNo = ilanNo;
            Fiyat = fiyat;
            Bahce = bahce;
            Garaj = garaj;
        }

        public bool Bahce { get; set; }
        public bool Garaj { get; set; } 
    }

    public class YazlikEv : Emlak
    {
        public YazlikEv(int oda, int salon, TypeOfHeating isinma, HomeStatus evDurumu, int ilanNo, string fiyat, HomeTypeEnum tipi, bool havuz, Manzara manzara) : base(oda, salon, isinma, evDurumu, ilanNo, fiyat, tipi)
        {
            Oda = oda;
            Salon = salon;
            IsitmaTipi = isinma;
            Tipi = tipi;
            Durumu = evDurumu;
            IlanNo = ilanNo;
            Fiyat = fiyat;
            Havuz = havuz;
            Manzara = manzara;
        }

        public bool Havuz { get; set; }
        public Manzara Manzara { get; set; }
    }

    public class ApartmanDairesi : Emlak
    {
        public ApartmanDairesi(int oda, int salon, TypeOfHeating isinma, HomeStatus evDurumu, int ilanNo, string fiyat, HomeTypeEnum tipi, int kat, bool balkon) : base(oda, salon, isinma, evDurumu, ilanNo, fiyat, tipi)
        {
            Oda = oda;
            Salon = salon;
            IsitmaTipi = isinma;
            Tipi = tipi;
            Durumu = evDurumu;
            IlanNo = ilanNo;
            Fiyat = fiyat;
            Kat = kat;
            Balkon = balkon;
        }

        public int Kat { get; set; }
        public bool Balkon { get; set; }
    }
}
