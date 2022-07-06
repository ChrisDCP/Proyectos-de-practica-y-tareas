using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataModel;
using CapaNegocios;

namespace CodeForms
{
    public partial class frmPersona : Form
    {
        private Persona _persona;
        private PersonaRules _personaRule;
        public frmPersona()
        {
            InitializeComponent();
            this._persona = new Persona();
            this._personaRule = new PersonaRules();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            
        }

        private void txtIdPersona_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {
            this._persona.Carnet = txtCarnet.Text;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this._persona.Nombre = txtNombre.Text;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                _personaRule.guardar(this._persona);
                MessageBox.Show(" Guardado");
            }
            catch
            {
                MessageBox.Show("Error...");
            }
        }

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == '\r')
            {
                Buscar(txtCarnet.Text);
                
            }
        }
       private void Buscar(string code)
        {
            var p = _personaRule.Buscar(code);
            if (p != null)
            {
                this._persona = p;
                MessageBox.Show("Ya existe deseas editar el usuario");
            }
            else
            {
                MessageBox.Show("No existe registro asociado al arnet buscado");
            }
        }
                     
      
       }
        
    }
              

            
      
   
    


