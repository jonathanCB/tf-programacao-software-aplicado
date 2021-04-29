﻿using Entities.Models;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Entities.Interfaces
{

    public interface IProdutoDAO
    {
        public List<VendProdStatusVenda> VendedorProdStatus();
        public List<Produto> ItenCategorias(String cat);
        public void NovoProduto(Produto prod);

    }
}