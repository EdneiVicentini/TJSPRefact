﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SGDAU.Desarquivamento.Domain.Models
{
    public partial class EFTJAdvogado
    {
        public int EFTJAdvogadoID { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Origem { get; set; }
        public bool Ativo { get; set; }
        public string CreateUserCode { get; set; }
        public DateTime CreateDTime { get; set; }
        public string UpdtUserCode { get; set; }
        public DateTime UpdtDTime { get; set; }
    }
}
