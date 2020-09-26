﻿using System;
using System.Collections.Generic;

namespace APIEdux.Domains
{
    public partial class Curtida
    {
        public int IdCurtida { get; set; }
        public int IdUsuario { get; set; }
        public int IdDica { get; set; }

        public virtual Dica IdDicaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public object Permissao { get; internal set; }
    }
}
