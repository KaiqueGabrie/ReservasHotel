﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel.Models
{
    public class Reserva
    {
        public int _id { get; set; }
        public string _nome { get; set; }
        public string? _cpf { get; set; }
        public string _email { get; set; }
        public string _telefone { get; set; }
        public DateOnly _dtCheckin { get; set; }
        public DateOnly _dtCheckout { get; set; }
        public int _hospedes { get; set; }
        public string _prefQuarto { get; set; }
        public string _tpQuarto { get; set; }
        public string _FormaPag { get; set; }

        public void SetCPF(string cpf)
        {
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");
            try
            {
                if (cpf.Length == 11)
                {
                    this._cpf = cpf;
                }
                else
                {
                    MessageBox.Show("|ERRO| O CPF é inválido!!");
                }

            }catch (Exception ex) {
                MessageBox.Show($"|ERRO| O CPF é inválido!! {ex.Message}");
            }
        }
        public string GetCpf()
        {
            return _cpf;
        }
    }
}
