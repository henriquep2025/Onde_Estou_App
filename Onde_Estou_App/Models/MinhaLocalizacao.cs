using Android.Systems;
using Java.Time.Chrono;
using System;
using System.Collections.Generic;
using System.Text;
using static Android.Provider.MediaStore;
using static Android.Telephony.CarrierConfigManager;

namespace OndeEstouApp.Models
{
    public partial class MinhaLocalizacao
    {

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string FeatureName { get; set; } // Nome do local ou número
        public string Thoroughfare { get; set; } // Rua / Logradouro
        public string SubLocality { get; set; } // Bairro
        public string Locality { get; set; } // Cidade
        public string AdminArea { get; set; } // Estado
        public string PostalCode { get; set; } // CEP
        public string CountryName { get; set; } // País

    }
}
