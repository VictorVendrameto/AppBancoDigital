﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppBancoDigital.Model;
using AppBancoDigital.Service;
using Xamarin.Essentials;
using System.Net.Mail;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string[] cpf_pontuado = cpf.Text.Split('.', '-');
                string[] cpf_digitado = cpf_pontuado[0] + cpf_pontuado[1] + cpf_pontuado[2] + cpf_pontuado[3];

                Correntista c = await DataServiceCorrentista.SignOn(new Correntista
                {
                    Nome = user.Text,
                    Cpf = cpf_digitado,
                    Data_nasc = dtpck_DataNasc.Date,
                    Email = email.Text,
                    Senha = user_pw.Text,
                    Data_cad = DateTime.Now,

                });

                if (c.id != null)
                {
                    App.DadosCorren = c;

                    await Navigation.Push
                }
                else 
                {
                    
                }
            }
            catch
            {

            }
        }
    }
}